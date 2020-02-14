using System;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new ReminderItem(DateTimeOffset.Parse("13-02-2020 5:30:00"), "To work");
            var item2 = new ReminderItem(DateTimeOffset.Parse("13-02-2020 16:30:00"), "To home");
            
            item1.WriteProperties();
            item2.WriteProperties();
        }
    }
}
