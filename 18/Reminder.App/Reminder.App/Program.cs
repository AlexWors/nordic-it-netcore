using System;
using System.Collections.Generic;
using Reminder.Storage.Core; 
using Reminder.Storage.InMemory;
using Reminder.Domain;
using Reminder.Domain.EventArgs;
using Reminder.Receiver.Core;
using Reminder.Receiver.Telegram;
using System.Net;
using MihaZupan;
using Reminder.Sender.Core;
using Reminder.Sender.Telegram;

namespace Reminder.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const string token = "999422839:AAGbve-xfjsurJJydPuMeOLu2LwcUOwOVns";
            const string proxyHost = "96.96.33.133";
            const int proxyPort = 1080;

            IWebProxy proxy = new HttpToSocks5Proxy(proxyHost, proxyPort);

            IReminderStorage storage = new InMemoryReminderStorage();

            IReminderReceiver receiver = new TelegramReminderReceiver(token, proxy);

            IReminderSender sender = new TelegramReminderSender(token, proxy);

            ReminderDomain domain = new ReminderDomain(storage, receiver, sender);

            domain.ReminderItemStatusChanged += OnReminderItemReady;
            domain.ReminderItemStatusFailed += OnReminderItemSendingFailure;

            domain.Run();
            Console.WriteLine("press any key to continue");
            Console.ReadKey();

            //item.Message = "UPDATE MESSAGE!";

            //storage.Update(item);

            //List<ReminderItem> list = storage.Get(ReminderItemStatus.Awaiting);

            //foreach(var i in list)
            //{
            //    Console.WriteLine(i);
            //}
        }

        private static void OnReminderItemReady(object sender, ReminderItemStatusChangedEventArgs e)
        {
            Console.WriteLine($"Reminder of contact {e.Reminder.ContactId} " +
                $"has changed status from {e.Reminder.PreviousStatus} " +
                $"to {e.Reminder.Status} !");
        }

        private static void OnReminderItemSendingFailure(object sender, ReminderItemSendingFailedEventArgs e)
        {
            Console.WriteLine($"Reminder {e.Reminder.ContactId} failed to send with exception {e.Reminder.WriteException.Message}!");
        }
    }
}
