using Calculator.Figure;
using Calculator.Operation;
using System;

namespace ClasswWork16
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);
            Console.WriteLine("Perimeter is: ");
            var getPerimeter = circle.Calculate(CircleOperation.CalculatePerimeter);
            //var getPerimeter = circle.Calculate(r => 2 * Math.PI * r * r);
            Console.Write(getPerimeter);

            Square square = new Square(2);
            Console.WriteLine("Perimeter is: ");
            double getPerimeter2 = square.Calculate2(SquareOperation.CalculatePerimeter);
            Console.Write(getPerimeter2);

        }
    }
}
