using System;
namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());
            double answer = (2 * Math.PI * radius);
            Console.WriteLine("answer:"+ " " + answer);
        }
    }
}
