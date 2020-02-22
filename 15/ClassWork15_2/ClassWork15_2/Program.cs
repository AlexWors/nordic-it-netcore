using System;
using System.Linq;

namespace ClassWork15_2
{
    //delegate int PerformClaculator(int[] Array);
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new[] {12, 2, -4, 10, 54 };

            //PerformClaculator calc = Sum;
            //Другой способ
            Func<int[], int> calc = Sum;
            Console.WriteLine(calc(Array));

            calc = Min;
            Console.WriteLine(calc(Array));

            calc = Enumerable.Max;
            Console.WriteLine(calc(Array));
        }

        static int Sum(int[] array)
        {
            int Sum = 0;

            foreach(int i in array)
            {
                Sum += i;
            }
            return Sum;
        }
        static int Min(int[] array)
        {
            int Min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] < Min)
                {
                    Min = array[i];
                }
            }
            return Min;
        }
    }
}
