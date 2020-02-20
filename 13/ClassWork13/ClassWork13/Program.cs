using System;

namespace ClassWork13
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var plane = new Plane(800, 4);
				plane.TakeUpper(500);
				plane.TakeLower(400);
				plane.WriteAllProperties();

				var helicopter = new Helicopter(500, 8);
				helicopter.TakeUpper(600);
				helicopter.TakeLower(600);
				helicopter.WriteAllProperties();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
