using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork12
{
	class BaseDocument
	{
		public string DocName { get; set; }

		public string DocNumber { get; set; }

		public DateTimeOffset IssueDate { get; set; }

		public virtual string PropertiesString { get { return $"Документ: {DocName} " + $"Номер документа: {DocNumber} " + $"Дата: {IssueDate:dd-MM-yy}"; } }

		public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
		{
			DocName = docName;
			DocNumber = docNumber;
			IssueDate = issueDate;
		}


		
		public void WriteToConsole() 
		{
			Console.WriteLine(PropertiesString);
		}
	}
}
