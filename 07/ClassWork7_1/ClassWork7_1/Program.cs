using System;

namespace ClassWork7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter underString: ");
            string underStr = Console.ReadLine();
            int index = 0;
            string indexes = string.Empty; 
            do
            {
                index = str.IndexOf(underStr, index);
                if (index < 0)
                break;
                
                indexes += index + " ";
                index++;
            }
            while (true);

            if(string.IsNullOrEmpty(indexes))
            {
                Console.WriteLine("Serching string is not found!");
            }
            else
            Console.WriteLine("indexes substrings in string: " + indexes);
        }
    }
}
