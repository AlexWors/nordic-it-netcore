using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 3;
            string[] names = new string[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the name of person #{i}: ");
                names[i] = Console.ReadLine();
            }

            int[] ages = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the age of person #{i}: ");
                ages[i] = int.Parse(Console.ReadLine()) + 4;
            }

            for(int i = 0; i < arrayLength;  i++)
            {
                Console.WriteLine("Name: " + names[i] + " age in 4 years: " + ages[i]);
            }



        }
    }
}
