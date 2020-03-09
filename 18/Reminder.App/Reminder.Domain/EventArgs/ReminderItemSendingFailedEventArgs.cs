using Reminder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.EventArgs
{
    public class ReminderItemSendingFailedEventArgs : System.EventArgs
    {
        public ReminderItemSendingFailedModel Reminder { get; set; }

        //public Exception WriteException { get; set; }

        public ReminderItemSendingFailedEventArgs(ReminderItemSendingFailedModel reminder)
        {
            Reminder = reminder;
        }
    }
}
