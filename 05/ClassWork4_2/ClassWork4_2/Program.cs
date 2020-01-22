using System;

namespace ClassWork4_2
{
    class Program
    {
        public enum Color { Red, Green, Blue }
        static void Main(string[] args)
        {
            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;






                    //Console.WriteLine(" Введите число от 1 до 100: ");
                    //int number = int.Parse(Console.ReadLine());
                    //string message;
                    //message = number < 50 ? " Введенное число меньше 50" :  " Введенное число больше либо равно 50";
                    //Console.WriteLine(message);

            }
        }
    }
}