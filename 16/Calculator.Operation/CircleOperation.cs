using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operation
{
    public static class CircleOperation
    {
        public static double CalculatePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double CalculateSquare(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
