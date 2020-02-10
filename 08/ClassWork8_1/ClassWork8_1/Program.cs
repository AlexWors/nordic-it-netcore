using System;
using System.Collections.Generic;

namespace ClassWork8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> numbers = new Queue<double>();
            Console.WriteLine("Введите числа для извлечения квадратного корня: ");

            string input;
            while (true)
            {
                input = Console.ReadLine();
                numbers.Enqueue(double.Parse(input));

                if (input == "run")
                {
                    while (numbers.Count > 0)
                    {
                        double result = numbers.Dequeue();
                        Console.WriteLine(Math.Sqrt(result));                         
                    }

                    continue;
                }                
                else if(input == "exit")
                {
                    Console.WriteLine($"Завершение работы. Число оставшихся задач {numbers.Count}");
                    break;
                }

                
                
            }

        }
    }
}
