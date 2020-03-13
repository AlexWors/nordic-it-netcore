using System;
using System.Collections.Generic;
using System.Threading;
using Reminder.Domain.EventArgs;
using Reminder.Domain.Model;
using Reminder.Parsing;
using Reminder.Receiver.Core;
using Reminder.Sender.Core;
using Reminder.Storage.Core;

namespace Reminder.Domain
{
    public class ReminderDomain
    {
        private IReminderStorage _storage;
        private IReminderReceiver _receiver;
        private IReminderSender _sender;

        private Timer _awaitingRemindersCheckTimer;
        private Timer _readyReminderSendTimer;

        public event EventHandler<ReminderItemStatusChangedEventArgs> ReminderItemStatusChanged;
        public event EventHandler<ReminderItemSendingFailedEventArgs> ReminderItemStatusFailed;



        public ReminderDomain(IReminderStorage storage, IReminderReceiver receiver, IReminderSender sender)
        {
            _storage = storage;
            _receiver = receiver;
            _sender = sender;

            _receiver.MessageReceived += ReceiverOnMessageReceived;
        }

        public void Run()
        {
            _awaitingRemindersCheckTimer = new Timer(
                CheckAwaitingReminders,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(1));
            _readyReminderSendTimer = new Timer(
                SendReadyReminders, 
                null, 
                TimeSpan.Zero, 
                TimeSpan.FromSeconds(1));

            _receiver.Run();
        }

        private void CheckAwaitingReminders(object dummy)
        {
            // read items in status Awaiting
            List<ReminderItem> list = _storage.Get(ReminderItemStatus.Awaiting);
            foreach(ReminderItem item in list)
            {
                // check and if IsTimeToSend
                if (item.IsTimeToSend)
                {
                    // then update status to ReadyToSend
                    ReminderItemStatus previousStatus = item.Status;
                    item.Status = ReminderItemStatus.ReadyToSend;
                    _storage.Update(item);
                    ReminderItemStatusChanged?.Invoke(this, new ReminderItemStatusChangedEventArgs(new Model.ReminderItemStatusChangedModel(item, previousStatus)));
                }
            }
        }

        private void SendReadyReminders(object dummy)
        {
            // read items in status ReadyToSend
            var items = _storage.Get(ReminderItemStatus.ReadyToSend);
            foreach(ReminderItem item in items)
            {
                var previousStatus = item.Status;
                // and try To Send
                try
                {

                    _sender.Send(item.ContactID, item.Message);
                    // if okay raise event SendingSucceeded

                    item.Status = ReminderItemStatus.SuccessfullySent;
                    _storage.Update(item);
                    ReminderItemStatusChanged?.Invoke(
                        this, 
                        new ReminderItemStatusChangedEventArgs(
                            new ReminderItemStatusChangedModel(
                                item, 
                                previousStatus)));
                }
                catch(Exception e)
                {
                    // if exception raise event SendingFailed
                    item.Status = ReminderItemStatus.Failed;
                    _storage.Update(item);
                    ReminderItemStatusFailed?.Invoke(
                        this, 
                        new ReminderItemSendingFailedEventArgs(
                            new ReminderItemSendingFailedModel(
                                item, 
                                previousStatus,
                                e)));
                }
            }
        }

        private void ReceiverOnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            //parsing of the e.Message to get
            var parsedMessage = MessageParser.ParseMessage(e.Message);

            if(parsedMessage == null)
            {
                //we can rise some MessageParsingFailed event
            }

            
            var item = new ReminderItem(
                Guid.NewGuid(),
                e.ContactId,
                parsedMessage.Date,
                parsedMessage.Message);
            //adding new reminder item to the strage
            _storage.Add(item);

            //send message that reminder item was added 
            _sender.Send(e.ContactId, "Reminder added!");
        }
    }
}
