using Reminder.Storage.Core;
using System;

namespace Reminder.Domain.Model
{
    public class ReminderItemStatusChangedModel
    {
        public string ContactId { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

        public ReminderItemStatus Status { get; set; }

        public ReminderItemStatus PreviousStatus { get; set; }

        public ReminderItemStatusChangedModel(ReminderItem reminderItem, ReminderItemStatus previousStatus)
        {
            Date = reminderItem.Date;
            ContactId = reminderItem.ContactId;
            Message = reminderItem.Message;
            Status = reminderItem.Status;
            PreviousStatus = previousStatus;
        }
    }
}
