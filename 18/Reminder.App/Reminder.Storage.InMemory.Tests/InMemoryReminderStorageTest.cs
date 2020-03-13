using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using System;

namespace Reminder.Storage.InMemory.Tests
{
    [TestClass]
    public class InMemoryReminderStorageTest
    {
        [TestMethod]
        public void Method_Add_With_Not_Null_Item_Should_Store_The_Item_Internally()
        {
            //prepare test data
            var storage = new InMemoryReminderStorage();
            var expected = new ReminderItem(
                Guid.NewGuid(), 
                "TelegramContactId", 
                DateTimeOffset.Now, 
                "Hello><");

            //do the test
            storage.Add(expected);


            //chek result
            var actual = storage.Get(expected.Id);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.ContactID, actual.ContactID);
            Assert.AreEqual(expected.Status, actual.Status);
            Assert.AreEqual(expected.Date, actual.Date);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]

        public void Method_Get_By_Id_Should_Return_Null_For_Empty_Storage()
        {
            //prepare test data
            var storage = new InMemoryReminderStorage();

            //do the test
            var actual = storage.Get(Guid.Empty);

            //chek result
            Assert.IsNull(actual);
        }

        [TestMethod]

        public void Method_Get_By_Id_Should_Return_Not_Null_Null_For_Existing_Item_In_Storage()
        {
            //prepare test data
            var storage = new InMemoryReminderStorage();
            var expected = new ReminderItem(
                Guid.NewGuid(), 
                "TelegramContactId", 
                DateTimeOffset.Now, 
                "Hello><");
            storage.Storage.Add(expected.Id, expected);

            //do the test
            var actual = storage.Get(expected.Id);

            //chek result
            Assert.IsNotNull(actual);
        }
    }
}
