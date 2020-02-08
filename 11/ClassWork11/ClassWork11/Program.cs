using System;

namespace ClassWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "Alex",
                Age = 54
            };
            Console.WriteLine(p.PropertiesString);
        }
    }
}
