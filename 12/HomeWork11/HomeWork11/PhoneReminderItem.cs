using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11
{
    public class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }

        public override void WriteProperties()
        {
            Console.WriteLine($"{GetType().Name}, Alarm date: {AlarmDate:dd.MM.yyyy HH:mm:ss}, alarm mesage: {AlarmMessage}, time to alarm: {TimeToAlarm}, phone number: {PhoneNumber}, is outdated: {IsOutdated},");
        }
    }
}
