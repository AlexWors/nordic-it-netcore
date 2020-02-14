using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork12
{
	class Passport : BaseDocument
	{
		public string Country { get; set; }

		public string PersonName { get; set; }

		public override string PropertiesString { get { return $"Имя документа: {DocName} " + $"Номер документа: {DocNumber} " + $"Дата: {IssueDate:dd-MM-yy} " + $"Имя чела: {PersonName} " + $"Страна: {Country}"; } }

		public Passport(string docNumber, DateTimeOffset issueDate, string country, string personName)
			:base("Passport", docNumber, issueDate)
		{
			Country = country;
			PersonName = personName;
		}

		public void ChangeIssueDate(DateTimeOffset newIssueDate)
		{
			IssueDate = newIssueDate;
		}


		//public new void WriteToConsole()
		//{
		//	Console.WriteLine(PropertiesString);
		//}
	}
}
