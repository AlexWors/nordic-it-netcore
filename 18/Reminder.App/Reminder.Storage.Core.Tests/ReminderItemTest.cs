using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Reminder.Storage.Core.Tests
{
    [TestClass]
    public class ReminderItemTest
    {
        [TestMethod]
        public void Property_TimeToAllarm_Should_Be_Negative_For_Date_In_The_Past()
        {
            //prepare test data
            ReminderItem item = new ReminderItem(Guid.Empty, null, DateTimeOffset.Now.AddSeconds(-1), null, ReminderItemStatus.Awaiting);

            //do the test
            TimeSpan delta = item.TimeToAlarm;

            //chek result
            Assert.IsTrue(delta < TimeSpan.Zero);

        }
    }
}
