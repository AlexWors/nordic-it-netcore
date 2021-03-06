﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11
{
    public class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm { get { return AlarmDate - DateTimeOffset.Now; } }

        public bool IsOutdated { get {return AlarmDate < DateTimeOffset.Now; } }

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage) 
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public virtual void WriteProperties()
        {
            Console.WriteLine($"{GetType().Name}, Alarm date: {AlarmDate:dd.MM.yyyy HH:mm:ss}, alarm mesage: {AlarmMessage}, time to alarm: {TimeToAlarm}, is outdated: {IsOutdated}");
        }
    }
}
