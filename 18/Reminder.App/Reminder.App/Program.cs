using System;
using System.Collections.Generic;
using Reminder.Storage.Core; 
using Reminder.Storage.InMemory;

namespace Reminder.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IReminderStorage storage = new InMemoryReminderStorage();
            storage.Add(new ReminderItem(Guid.NewGuid(), "TelegramContactId", DateTimeOffset.Now, "Hello><", null));

            List<ReminderItem> list = storage.Get(ReminderItemStatus.Awaiting);
        }
    }
}
