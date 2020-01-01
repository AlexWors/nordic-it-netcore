using System;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose your destiny:");
            Console.WriteLine("1) addition");
            Console.WriteLine("2) subtraction");
            Console.WriteLine("3) multiplication");
            Console.WriteLine("4) division");
            Console.WriteLine("5) remainder of the division");
            Console.WriteLine("6) exponentiation");
            Console.WriteLine("choose the desired number and press enter");
            int oper = int.Parse(Console.ReadLine());
            double total;

            
            
            if (oper == 1)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                total = firstNumber + secondNumber;
                Console.WriteLine("your destiny is addiction of numbers = " + total);
            }
            else if(oper == 2)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                total = firstNumber - secondNumber;
                Console.WriteLine("your destiny is substraction of numbers = " + total);
            }
            else if(oper == 3)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                total = firstNumber * secondNumber;
                Console.WriteLine("your destiny is multiplication of numbers = " + total);
            }
            else if(oper == 4)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                total = firstNumber / secondNumber;
                Console.WriteLine("your destiny is division of numbers = " + total);
            }
            else if(oper == 5)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                total = firstNumber % secondNumber;
                Console.WriteLine("your destiny is remainder of the division of numbers = " + total);
            }
            else if(oper == 6)
            {
                Console.WriteLine("Enter the number: ");
                double exponentialNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the degree: ");
                int degree = int.Parse(Console.ReadLine());
                total = Math.Pow(exponentialNumber, degree);
                Console.WriteLine("your destiny is exponentiation of number = " + total);
            }
        }
    }
}
