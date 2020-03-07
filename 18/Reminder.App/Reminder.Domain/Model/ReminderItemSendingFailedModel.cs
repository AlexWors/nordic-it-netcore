using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.Model
{
    class ReminderItemSendingFailedModel
    {
        public string ContactId { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

        public ReminderItemStatus Status { get; set; }

        public ReminderItemSendingFailedModel(ReminderItem reminderItem)
        {
            Date = reminderItem.Date;
            ContactId = reminderItem.ContactId;
            Message = reminderItem.Message;
            Status = reminderItem.Status;
        }
    }
}
