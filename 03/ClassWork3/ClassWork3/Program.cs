using ClassWork3.Properties;
using System;
using System.Globalization;
using System.Text;
using System.Threading;


namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*object s;
            s = 10;
            Console.WriteLine((int)s + 5);*/

            if (args != null && args.Length > 0)
            {
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(args[0]);

            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            }

            Console.InputEncoding = Encoding.ASCII;
            Console.OutputEncoding = Encoding.Unicode;

            //Console.Write("Введите дробное число ");
            Console.Write(Resources.NumberPrompt);
            string input = Console.ReadLine();

           

            double number = double.Parse(input);

            //Console.WriteLine("Результат возведения в квадрат: " + number * number);
            Console.WriteLine(Resources.Result + number * number);


            //Arrays

            /*int[] integerArray = new int[3];

            integerArray[0] = 1;
            integerArray[1] = -5;
            integerArray[2] = 999;

            for(int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            string[] names =
            {
                "emi",
                "bob",
                "elsa"
            };

            names[0] = "nick";

            string[] array = "emi, , , bob, elsa".Split(separator: ", ",
                StringSplitOptions.RemoveEmptyEntries);

            Array.Resize(ref array, newSize: 10);*/
            

        }
    }
}
