using System;

namespace HomeWork7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (string.IsNullOrEmpty(input))
            {
                try
                {
                    Console.WriteLine("Введите непустую строку: ");
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new Exception("Вы ввели пустую строку :( Попробуйте ещё раз: ");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            char[] inputReverse = input.ToCharArray();
            Array.Reverse(inputReverse);
            input = new string(inputReverse);
            Console.WriteLine(input.ToLower());
        }
    }
}
