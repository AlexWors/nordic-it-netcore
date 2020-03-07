using System;
using System.Collections.Generic;
using System.Threading;
using Reminder.Domain.EventArgs;
using Reminder.Domain.Model;
using Reminder.Storage.Core;

namespace Reminder.Domain
{
    public class ReminderDomain
    {
        private IReminderStorage _storage;

        private Timer _awaitingRemindersCheckTimer;

        private Timer _readyReminderSendTimer;

        public event EventHandler<ReminderItemStatusChangedEventArgs> ReminderItemStatusChanged;
        public event EventHandler<ReminderItemSendingFailedEventArgs> ReminderItemStatusFailed;



        public ReminderDomain(IReminderStorage storage)
        {
            _storage = storage;
        }

        public void Run()
        {
            _awaitingRemindersCheckTimer = new Timer(
                CheckAwaitingReminders,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(1));
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
            List<ReminderItem> list = _storage.Get(ReminderItemStatus.ReadyToSend);
            foreach(ReminderItem item in list)
            {
                // and try To Send
                try
                {
                    // if okay raise event SendingSucceeded
                    item.Status = ReminderItemStatus.SuccessfullySent;
                    _storage.Update(item);
                }
                catch
                {
                    // if exception raise event SendingFailed
                }
            }

            
            
        }
    }
}
