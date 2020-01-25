using System;

namespace ClassWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            string resultMultiplication = firstNumber + " * " + secondNumber + " = " + Math.Round(firstNumber * secondNumber, 2);
            Console.WriteLine(resultMultiplication);

            string resultAddition = string.Format("{0} + {1} + {2:#.##}", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine(resultAddition);

            string resultSubstraction = $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber:#.##}";
            Console.WriteLine(resultSubstraction);

        }
    }
}
