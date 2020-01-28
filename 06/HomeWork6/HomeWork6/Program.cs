using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string strNumber = string.Empty;
            Console.WriteLine("Enter a natural number of not more than 2 billion: ");
            do
            {
                try
                {
                    strNumber = Console.ReadLine();
                    number = int.Parse(strNumber);
                    if(number <= 0)
                    {
                        Console.WriteLine("Number must be greater than zero!");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered a number greater than 2 billion!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered wrong data! Try again");
                }
            } while (number <= 0);
            int evenDigits = 0;
            for(int i = 0; i < strNumber.Length; i++)
            {
                var num = int.Parse(strNumber[i].ToString());
                if(num % 2 == 0)
                {
                    evenDigits++;
                }
            }
            Console.WriteLine($"{number} contains {evenDigits} even numbers.");
            
        }
    }
}
