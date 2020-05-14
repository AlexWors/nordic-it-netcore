using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage.Core
{
	public class ReminderItemRestricted
	{
			/// <summary>
			/// Gets or sets the date and time the reminder item scheduled for sending.
			/// </summary>
			public DateTimeOffset Date { get; set; }

			/// <summary>
			/// Gets or sets contact identifier in the target sending system.
			/// </summary>
			public string ContactId { get; set; }

			/// <summary>
			/// Gets or sets the message of the reminder item for sending to the recipient.
			/// </summary>
			public string Message { get; set; }

			/// <summary>
			/// Gets or sets the identifier of the recipient.
			/// </summary>
			public ReminderItemStatus Status { get; set; }
		}
	}
