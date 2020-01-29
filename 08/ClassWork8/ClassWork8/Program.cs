    using System;
using System.Collections.Generic;

namespace ClassWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            //или var
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            Console.WriteLine(string.Join(", ", intList));

            var listOfStrings = new List<string>();
            listOfStrings.Add("one");
            listOfStrings.Add("one");
            listOfStrings.Add("one");
            listOfStrings.Add("one");

            Console.WriteLine(string.Join(", ", listOfStrings));

            var list = new List<int>
            {
                1,
                2,
                3
            };

        }
    }
}
