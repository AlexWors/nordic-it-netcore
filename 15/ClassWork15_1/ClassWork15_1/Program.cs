using System;

namespace ClassWork15_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var acc1 = new Account<int>(66, "Andrei");

            var acc2 = new Account<string>("53 ", " Alex");

            var acc3 = new Account<Guid>(Guid.NewGuid(), " Billy");
            Console.WriteLine(Guid.NewGuid());

            acc1.WriteProperties();
            acc2.WriteProperties();
            acc3.WriteProperties();
        }
    }
}
