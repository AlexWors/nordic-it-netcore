using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string strNumber;
            Console.WriteLine("Enter a natural number of not more than 2 billion: ");
            do
            {
                strNumber = Console.ReadLine();
                if (int.TryParse(strNumber, out number))
                    break;
                Console.WriteLine("You entered wrong data! Try again");
            } while (true);
            int evenDigits = 0;
            for(int i = 0; i < strNumber.Length; i++)
            {
                var num = int.Parse(i.ToString());
                if(num % 2 == 0)
                {
                    evenDigits++;
                }
            }
            Console.WriteLine($"{number} contains {evenDigits} even numbers.");
            
        }
    }
}
