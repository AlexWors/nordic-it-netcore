using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.Model
{
    public class ReminderItemSendingFailedModel
    {
        public string ContactId { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Message { get; set; }

        public string AlarmMessage { get; set; }

        public ReminderItemStatus PreviousStatus { get; set; }

        public DateTimeOffset AlarmDate { get; set; }

        public ReminderItemStatus Status { get; set; }

        public Exception WriteException { get; set; }

        public ReminderItemSendingFailedModel()
        {

        }

        public ReminderItemSendingFailedModel(ReminderItem reminderItem, ReminderItemStatus previousStatus, Exception exception)
        {
            Date = reminderItem.Date;
            ContactId = reminderItem.ContactID;
            Message = reminderItem.Message;
            Status = reminderItem.Status;
            PreviousStatus = previousStatus;
            WriteException = exception;
        }
    }
}
