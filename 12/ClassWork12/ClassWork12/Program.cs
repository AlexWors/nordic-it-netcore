using System;

namespace ClassWork12
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument b1 = new BaseDocument(
				"Passport",
				"X674",
				DateTimeOffset.Parse("09 - 12 - 1995"));
			b1.WriteToConsole();

			Passport b2 = new Passport(
				"X674",
				DateTimeOffset.Parse("09 - 12 - 1995"),
				"United Kingdom",
				"Chyvak");
			b2.WriteToConsole();

			var documents = new BaseDocument[2];

			documents[0] = new BaseDocument("Drive License", "X674", DateTimeOffset.Parse("09 - 12 - 1995"));

			documents[1] = new Passport("Y545", DateTimeOffset.Parse("09 - 12 - 1995"), "Russia", "Ivan");

			foreach(var doc in documents)
			{
				if(doc is Passport)
				{
					((Passport)doc).ChangeIssueDate(DateTimeOffset.Now);
				}

				doc.WriteToConsole();
			}
		}
	}
}
