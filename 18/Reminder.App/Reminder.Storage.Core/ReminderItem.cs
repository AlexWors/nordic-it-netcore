using System;

namespace Reminder.Storage.Core
{
    public class ReminderItem
    {
        public Guid Id { get; }

        public string ContactId { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

        public ReminderItemStatus Status { get; set; }

        public TimeSpan TimeToAllarm => Date - DateTimeOffset.Now;

        public ReminderItem(Guid id, string contactId, DateTimeOffset date, string message, ReminderItem status)
        {
            Id = id;
            ContactId = contactId;
            Date = date;
            Message = message;
            //Status = status;
        }

        public override string ToString()
        {
            return $"{typeof(ReminderItem)}" + $"{Id}: " + $"{Status}; " + $"Fire Date: {Date}; " + $"Contact ID: {ContactId}; " + $"Message:\"{Message}\"";
        }
    }
}
