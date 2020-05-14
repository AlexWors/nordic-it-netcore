using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reminder.Storage.Core;
using Reminder.Storage.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Reminder.Storage.WebApi
{
    [ApiController]
    [Route("api/reminders")]
    public class RemindersController : ControllerBase
    {
        private readonly ILogger<RemindersController> _logger;
        private readonly IReminderStorage _reminderStorage;

        public RemindersController(
            ILogger<RemindersController> logger,
            IReminderStorage reminderStorage)
        {
            _logger = logger;
            _reminderStorage = reminderStorage;
        }

        [HttpGet]
        public IActionResult GetReminders(
            [FromQuery(Name = "[paging]count")] int count = 0,
            [FromQuery(Name = "[paging]startPosition")] int startPosition = 0)
        {
            List<ReminderItem> reminderItems = _reminderStorage.Get(count, startPosition);
            List<ReminderItemGetModel> reminderItemGetModels =
                reminderItems
                .Select(x => new ReminderItemGetModel(x))
                .ToList();

            return Ok(reminderItemGetModels);
        }

        [HttpGet("{id}")]
        public IActionResult GetReminder(Guid id)
        {
            var reminderItem = _reminderStorage.Get(id);
            if (reminderItem == null)
            {
                return NotFound();
            }

            return base.Ok(new ReminderItemGetModel(reminderItem));
        }

        [HttpPost]
        public IActionResult CreateReminder([FromBody] ReminderItemCreateModel reminderItemCreateModel)
        {
            if(reminderItemCreateModel == null)
            {
                return BadRequest();
            }

            var reminderItemRestricted = reminderItemCreateModel.ToReminderItemRestricted();

            Guid id = _reminderStorage.Add(reminderItemRestricted);

            var reminderItemGetModel = new ReminderItemGetModel(id, reminderItemRestricted);

            return CreatedAtAction(
                "GetReminder",
                new { id },
                reminderItemCreateModel);
        }
    }
}
