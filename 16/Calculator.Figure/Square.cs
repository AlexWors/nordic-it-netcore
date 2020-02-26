using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Figure
{
    public sealed class Square
    {
        private double _square;

        public Square(double square)
        {
            _square = square;
        }

        public double Calculate2(Func<double, double> operation)
        {
            return operation(_square);
        }
    }
}
