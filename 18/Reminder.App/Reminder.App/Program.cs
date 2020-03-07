using System;
using System.Collections.Generic;
using Reminder.Storage.Core; 
using Reminder.Storage.InMemory;
using Reminder.Domain;
using Reminder.Domain.EventArgs;

namespace Reminder.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IReminderStorage storage = new InMemoryReminderStorage();

            ReminderDomain domain = new ReminderDomain(storage);

            domain.ReminderItemStatusChanged += OnReminderItemReady;

            var item = new ReminderItem(Guid.NewGuid(), "TelegramContactId", DateTimeOffset.Now.AddSeconds(2), "Hello><", ReminderItemStatus.Awaiting);

            storage.Add(item);

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
    }
}
