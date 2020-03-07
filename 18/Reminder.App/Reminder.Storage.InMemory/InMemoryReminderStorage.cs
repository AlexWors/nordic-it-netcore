using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Storage.InMemory
{
    public class InMemoryReminderStorage : IReminderStorage
    {
        internal readonly Dictionary<Guid, ReminderItem> Storage;

        //public delegate void WhenAddingDone(object sender, EventArgs e);    
        //public WhenAddingDone RunWhenAddingDone { get; set; }

        public EventHandler RunWhenAddingDone { get; set; }

        public EventHandler RunWhenUpdatingDone { get; set; }

        public event EventHandler OnAddSuccess;

        public InMemoryReminderStorage()
        {
            Storage = new Dictionary<Guid, ReminderItem>();
        }

        public void Add(ReminderItem reminderItem)
        {
            Storage.Add(reminderItem.Id, reminderItem);
            if (RunWhenAddingDone != null)
                RunWhenAddingDone(this, EventArgs.Empty);

            if (OnAddSuccess != null)
                OnAddSuccess(this, EventArgs.Empty);
        }

        public void Update(ReminderItem reminderItem)
        {
            Storage[reminderItem.Id] = reminderItem;
            if(RunWhenUpdatingDone != null)
                RunWhenUpdatingDone(this, EventArgs.Empty);
        }

        public ReminderItem Get(Guid id)
        {
            return Storage.ContainsKey(id) ? Storage[id] : null;
        }

        public List<ReminderItem> Get(ReminderItemStatus status)
        {
            //var result = new List<ReminderItem>();
            //foreach(var reminderItem in _storage.Values)
            //{
            //    if (reminderItem.Status == status)
            //        result.Add(reminderItem);
            //}
            //return result;

            return Storage.Values.Where(x => x.Status == status).ToList(); //perfect variant
        }

        
    }
}
