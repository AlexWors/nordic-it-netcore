using System;
using System.Collections.Generic;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ReminderItem>
            {
                new ReminderItem(DateTimeOffset.Parse("18-02-2020 5:30:00"), "To work"),
                new PhoneReminderItem(DateTimeOffset.Parse("23-02-2020 16:30:00"), "Call the boss", "+79871234567"),
                new ChatReminderItem(DateTimeOffset.Parse("23-02-2020 17:55:00"), "Write a message", "boss killer", "Jack the ripper")
            };

            foreach (var item in list)
            {
                item.WriteProperties();
            }

        }
    }
}
