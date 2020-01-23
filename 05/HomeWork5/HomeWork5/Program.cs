using System;

namespace HomeWork5
{
    class Program
    {
        public enum geometricFigures
        {
            Circle = 1,
            Triangle = 2,
            Rectangle = 3
        }
        static void Main(string[] args)
        {
            double area = 0;
            double perimeter = 0;

            Console.WriteLine("Enter type of figure: ");
            Console.WriteLine("1 - Circle \n2 - Triangle \n3 - Rectangle");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Your entered wrong data!");
            }
            
            int figures = (int)(geometricFigures)input;
            try
            {
                switch (figures)
                {
                    case (int)geometricFigures.Circle:
                        Console.WriteLine("Enter circle radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        if (radius <= 0)
                            throw new Exception("The value should be more than 0!");
                        area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
                        perimeter = Math.Round(2 * Math.PI * radius, 2);
                        break;

                    case (int)geometricFigures.Triangle:
                        Console.WriteLine("Enter the side of the triangle: ");
                        double side = double.Parse(Console.ReadLine());
                        if (side <= 0)
                            throw new Exception("The value should be more than 0!");
                        area = Math.Round(Math.Pow(side, 2) * Math.Sqrt(3) / 4, 2);
                        perimeter = Math.Round(side * 3, 2);
                        break;

                    case (int)geometricFigures.Rectangle:
                        Console.WriteLine("Enter the hight of the rectangle: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width of the rectangle ");
                        double width = double.Parse(Console.ReadLine());
                        if (height <= 0 || width <= 0)
                            throw new Exception("The value should be more than 0!");
                        area = Math.Round(height * width, 2);
                        perimeter = Math.Round((2 * height) + (2 * width), 2);
                        break;
                    default:
                        throw new Exception("Figure not defined!");
                        

                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Your entered wrong data!");
            }
            

                Console.WriteLine($"Area of your figure = {area}");
                Console.WriteLine($"Perimeter of your figure = {perimeter}");
        
        
        }
    }
}
