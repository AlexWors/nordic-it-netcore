using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Storage.SqlServer.ADO.Tests.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Reminder.Storage.SqlServer.ADO.Tests
{
	[TestClass]
	public class SqlServerReminderStorageTest
	{
		private static string _connectionString;

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			_connectionString = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build()
				.GetConnectionString("DefaultConnection");
		}

		[TestInitialize]
		public void TestInitialize()
		{
			RunSqlScript(Resources.DatabaseSchema);
			RunSqlScript(Resources.DatabaseSPs);
			RunSqlScript(Resources.DatabaseTestData);
		}

		[TestMethod]
		public void Method_Add_Should_Return_Non_Empty_Guid_If_All_Correct()
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);

			Guid actual = storage.Add(new ReminderItemRestricted
			{
				ContactId = "ContactId",
				Date = DateTimeOffset.Now,
				Message = "Message",
				Status = ReminderItemStatus.Awaiting
			});

			Assert.AreNotEqual(Guid.Empty, actual);
		}

		[TestMethod]
		public void Method_Get_ReminderItemById_Should_Return_Item_If_Exists()
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);

			Guid id = Guid.Parse("00000000-0000-0000-0000-111111111111");
			ReminderItem actual = storage.Get(id);

			Assert.IsNotNull(actual);
		}


		[TestMethod]
		public void Method_Get_ReminderItemById_Should_Return_Null_If_Doesnt_Exist()
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);

			Guid id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			ReminderItem actual = storage.Get(id);

			Assert.IsNull(actual);
		}

		[TestMethod]
		public void Method_Get_With_Paging_Should_Return_All_Records_With_Default_Parameters()
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);
			var actual = storage.Get();
			Assert.IsNotNull(actual);
			Assert.AreEqual(8, actual.Count);
		}

		[TestMethod]
		public void Method_Get_With_Paging_Should_Return_3_Records_From_2_To_4_For_Parameters_3_2()
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);
			var actual = storage.Get(3, 2);

			Assert.IsNotNull(actual);
			Assert.AreEqual(3, actual.Count);
			Assert.AreEqual(Guid.Parse("00000000-0000-0000-0000-222222222222"), actual[0].Id);
			Assert.AreEqual(Guid.Parse("00000000-0000-0000-0000-333333333333"), actual[1].Id);
			Assert.AreEqual(Guid.Parse("00000000-0000-0000-0000-444444444444"), actual[2].Id);
		}

		[DataTestMethod]
		[DataRow("00000000-0000-0000-0000-777777777777", ReminderItemStatus.Failed)]

		public void Method_Update_By_Id_Should_Update_Status_To_Given(string guid, ReminderItemStatus status)
		{
			IReminderStorage storage = new SqlServerReminderStorage(_connectionString);
			storage.UpdateStatus(Guid.Parse(guid), status);
			var actual = storage.Get(Guid.Parse(guid));
			Assert.AreEqual(status, actual.Status);
		}

		private void RunSqlScript(string script)
		{
			using SqlConnection connection = GetOpenedSqlConnection();
			SqlCommand command = connection.CreateCommand();
			command.CommandType = CommandType.Text;

			string[] sqlInstructions = Regex.Split(script, @"\bGO\b");
			foreach (string sqlInstruction in sqlInstructions)
			{
				command.CommandText = sqlInstruction;
				command.ExecuteNonQuery();
			}
		}

		private SqlConnection GetOpenedSqlConnection()
		{
			var sqlConnection = new SqlConnection(_connectionString);
			sqlConnection.Open();
			return sqlConnection;
		}
	}
}
