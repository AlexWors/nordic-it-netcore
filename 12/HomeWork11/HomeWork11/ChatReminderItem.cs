using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork11
{
    public class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }

        public string AccountName { get; set; }

        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName) : base (alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }

        public override void WriteProperties()
        {
            Console.WriteLine($"{GetType().Name}, Alarm date: {AlarmDate:dd.MM.yyyy HH:mm:ss}, alarm mesage: {AlarmMessage}, time to alarm: {TimeToAlarm}, " + 
                $"Chat name: {ChatName}, Account name: {AccountName}, is outdated: {IsOutdated}");
        }
    }
}
