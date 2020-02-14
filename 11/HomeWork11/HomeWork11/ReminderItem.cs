using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm { get { return DateTimeOffset.Now - AlarmDate; } }

        public bool IsOutdated { get {return TimeToAlarm.TotalSeconds >= 0; } }

        public ReminderItem(DateTimeOffset alarmDate, string alarmMesage) 
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMesage;
        }

        public void WriteProperties()
        {
            Console.WriteLine($"Alarm date: {AlarmDate}, alarm mesage: {AlarmMessage}, time to alarm: {TimeToAlarm}, is outdated: {IsOutdated}");
        }
    }
}
