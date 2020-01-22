using System;

namespace ClassWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //byte numberOfLetters = 0;
            //Console.WriteLine("Enter string: ");
            //do
            //{
            //    str = Console.ReadLine();
            //    if (str == "exit")
            //        continue;
            //    numberOfLetters += (byte)str.Length;
            //    Console.WriteLine($"number of entered numbers: {numberOfLetters}");

            //}
            //while (str != "exit");

            //Console.WriteLine("Your entered " + str);
            //Console.ReadKey();



             var marks = new[]
             {
                new [] { 2, 3, 3, 2, 3}, // Monday (it was a good weekend :)
                new [] { 2, 4, 5, 3},    // Tuesday (anyway better than Monday)
                null,                    // Wednesday (felt sick, stayed at home :( )
                new [] { 5, 5, 5, 5},    // Thursday (God mode :)
                new [] { 4 }             // Friday (a very short day)
             };

            int marksCount = 0;
            int totalSum = 0;
            for (int j = 0; j < marks.Length; j++)
            {
                int sum = 0;
                if (marks[j] == null)
                {
                    Console.WriteLine("The average mark for day #3: N/A");
                    continue;
                }


                for (int i = 0; i < marks[j].Length; i++)
                {
                    sum += marks[j][i];
                    totalSum += marks[j][i];
                    marksCount++;

                }

                Console.WriteLine($"The average mark for day #{j}: {(float)sum / marks[j].Length}");
            }
            Console.WriteLine($"The average mark for week: {(float)totalSum / marksCount}");





        }
    }
}
