using System;

namespace ClassWork15
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var doubleCalculator = new Calculator<double>();
            var byteCalc = new Calculator<byte>();

            Console.WriteLine(doubleCalculator.Divide(10.0, 3));

            Console.WriteLine(byteCalc.Divide(255, 1));
        }
        
    }
}
