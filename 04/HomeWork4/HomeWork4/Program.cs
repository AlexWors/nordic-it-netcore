using System;

namespace HomeWork4
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            double size = double.Parse(Console.ReadLine());
            int large = (int)size / 20;
            int largeResidue = (int)size % 20;
            int medium = largeResidue / 5;
            int mediumResidue = largeResidue % 5;
            int small = mediumResidue;
            if (large >= 1 && medium > 1 || medium <= 3 && small >= 1 || small <= 4)
                Console.WriteLine("Вам потребуются упаковки: " + "Big: " + large + " Medium: " + medium + " small: " + small);
            
        }
        
    }
}
