using System;

namespace Reminder.Storage.Core
{
    public class ReminderItem
    {
        public Guid Id { get; }

        public string ContactID { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

        public ReminderItemStatus Status { get; set; }

        public TimeSpan TimeToAlarm => Date - DateTimeOffset.Now;

        public bool IsTimeToSend => TimeToAlarm <= TimeSpan.Zero;

        public ReminderItem(
            Guid id, 
            string contactId, 
            DateTimeOffset date, 
            string message)
        {
            Id = id;
            ContactID = contactId;
            Date = date;
            Message = message;
            Status = ReminderItemStatus.Awaiting;
        }

        public override string ToString()
        {
            return $"{typeof(ReminderItem)}" + 
                $"{Id}: " + 
                $"{Status}; " + 
                $"Fire Date: {Date}; " + 
                $"Contact ID: {ContactID}; " + 
                $"Message:\"{Message}\"";
        }
    }
}
