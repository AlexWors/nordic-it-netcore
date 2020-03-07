using Reminder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.EventArgs
{
    public class ReminderItemSendingFailedEventArgs : System.EventArgs
    {
        ReminderItemSendingFailedModel() { }

        public Exception SendException { get; set; }
    }
}
