using System;

namespace ClassWork4
{
    class Program
    {

        enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        [Flags]

        enum Pigs
        {
            NifNif = 1,
            NufNuf = 2,
            NafNaf = 4
        };

        enum Seasons
        {
            Winter = 3,
            Spring = 6,
            Summer = 9,
            autumn = 12
        };


        static void Main(string[] args)
        {

            Pigs theFirstGroup = Pigs.NifNif;

            Pigs allPigs = Pigs.NifNif | Pigs.NufNuf | Pigs.NafNaf;
            Pigs notInGroup = allPigs ^ theFirstGroup;
            Console.WriteLine(notInGroup);

            





            /*Console.WriteLine("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            double n = double.Parse(Console.ReadLine());

            double sqrt = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(a / (2 * Math.Tan(Math.PI / n)), 2));

            double sFull = (n * a / 2) * (a / (2 * Math.Tan(Math.PI / n)) + sqrt);

            Console.WriteLine(sFull);

            double sSide = (n * a / 2)*/


            byte a = 0b00001010;
            byte b = 0b0000100;

            Console.WriteLine(Convert.ToString(a & b, 2));
            Console.WriteLine(Convert.ToString(a | b, 2));
            Console.WriteLine(Convert.ToString(a ^ b, 2));


        }

    }
}
