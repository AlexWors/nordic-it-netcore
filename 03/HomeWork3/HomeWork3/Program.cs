using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 3;
            string[] names = new string[arrayLength];
            Console.Write("Enter first name: ");
            names[0] = Console.ReadLine();
            Console.Write("Enter the second name: ");
            names[1] = Console.ReadLine();
            Console.Write("Enter the third name: ");
            names[2] = Console.ReadLine();

            
            int[] ages = new int[arrayLength];
            {
                Console.Write("Enter the age of the #1 person: ");
                ages[0] = int.Parse(Console.ReadLine()) + 4;
                Console.Write("Enter the age of the #2 person: ");
                ages[1] = int.Parse(Console.ReadLine()) + 4;
                Console.Write("Enter the age of the #3 person: ");
                ages[2] = int.Parse(Console.ReadLine()) + 4;
            };

            for(int i = 0; i < arrayLength;  i++)
            {
                Console.WriteLine("Name: " + names[i] + " age in 4 years: " + ages[i]);
            }



        }
    }
}
