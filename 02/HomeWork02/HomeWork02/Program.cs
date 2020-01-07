using System;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number or degree:");
            double secondNumber = double.Parse(Console.ReadLine());

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
                
                total = firstNumber + secondNumber;
                Console.WriteLine("unswer = " + total);
            }
            else if(oper == 2)
            {
                total = firstNumber - secondNumber;
                Console.WriteLine("unswer = " + total);
            }
            else if(oper == 3)
            { 
                total = firstNumber * secondNumber;
                Console.WriteLine("unswer = " + total);
            }
            else if(oper == 4)
            {
                total = firstNumber / secondNumber;
                Console.WriteLine("unswer = " + total);
            }
            else if(oper == 5)
            {
                total = firstNumber % secondNumber;
                Console.WriteLine("unswer = " + total);
            }
            else if(oper == 6)
            {
                total = Math.Pow(firstNumber, secondNumber);
                Console.WriteLine("unswer = " + total);
            }
        }
    }
}
