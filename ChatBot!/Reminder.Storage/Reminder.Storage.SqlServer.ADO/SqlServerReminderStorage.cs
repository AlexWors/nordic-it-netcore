using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Reminder.Storage.Core;

namespace Reminder.Storage.SqlServer.ADO
{
    public class SqlServerReminderStorage : IReminderStorage
    {
        private string _connectionString;

        public SqlServerReminderStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Count => throw new NotImplementedException();

        public Guid Add(ReminderItemRestricted reminder)
        {
            var connection = GetOpenedSqlConnection();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[AddReminderItem]";
            command.Parameters.AddWithValue("@contactId", reminder.ContactId);
            command.Parameters.AddWithValue("@targetDate", reminder.Date);
            command.Parameters.AddWithValue("@message", reminder.Message);
            command.Parameters.AddWithValue("@status", (byte)reminder.Status);

            return (Guid)command.ExecuteScalar();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ReminderItem Get(Guid id)
        {
            var connection = GetOpenedSqlConnection();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "[dbo].[GetReminderItem]";
            command.Parameters.AddWithValue("@reminderId", id);
            using var reader = command.ExecuteReader();
            if (!reader.HasRows || reader.Read())
            {
                return null;
            }

            return new ReminderItem
            {
                Id = reader.GetGuid("Id"),
                ContactId = reader.GetString("ContactId"),
                Date = reader.GetDateTimeOffset(reader.GetOrdinal("TargetDate")),
                Message = reader.GetString("Message"),
                Status = (ReminderItemStatus)reader.GetByte("StatusId")
            };
        }

        public List<ReminderItem> Get(int count = -1, int startPosition = 0)
        {
            var result = new List<ReminderItem>();

            using var connection = GetOpenedSqlConnection();
            var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[GetReminderItemsWithPaging]";
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@startPosition", startPosition);
            using var reader = command.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                result.Add(
                 new ReminderItem
                 {
                     Id = reader.GetGuid("Id"),
                     ContactId = reader.GetString("ContactId"),
                     Date = reader.GetDateTimeOffset(reader.GetOrdinal("TargetDate")),
                     Message = reader.GetString("Message"),
                     Status = (ReminderItemStatus)reader.GetByte("StatusId")
                 });
            }

            return result;
        }

        public List<ReminderItem> Get(ReminderItemStatus status, int count = 0, int startPosition = 0)
        {
            var result = new List<ReminderItem>();

            using var connection = GetOpenedSqlConnection();
            var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[GetReminderItemsWithPaging]";
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@startPosition", startPosition);
            command.Parameters.AddWithValue("@statusId", (byte)status);
            using var reader = command.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                result.Add(
                 new ReminderItem
                 {
                     Id = reader.GetGuid("Id"),
                     ContactId = reader.GetString("ContactId"),
                     Date = reader.GetDateTimeOffset(reader.GetOrdinal("TargetDate")),
                     Message = reader.GetString("Message"),
                     Status = (ReminderItemStatus)reader.GetByte("StatusId")
                 });
            }

            return result;
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(IEnumerable<Guid> ids, ReminderItemStatus status)
        {
            foreach (var id in ids)
            {
                UpdateStatus(id, status);
            }
        }

        public void UpdateStatus(Guid id, ReminderItemStatus status)
        {
            using var connection = GetOpenedSqlConnection();
            var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[UpdateReminderItem]";
            command.Parameters.AddWithValue("@statusId", status);
            command.Parameters.AddWithValue("@reminderId", id);
            command.ExecuteNonQuery();
        }

        private SqlConnection GetOpenedSqlConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
