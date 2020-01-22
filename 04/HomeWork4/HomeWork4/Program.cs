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
            if (large == 0)
            {
                Console.WriteLine();
            }
            else if (large >= 1)
            {
                Console.WriteLine("Вам потребуются упаковки: " + "Big: " + large);
            }
            
            if (medium == 0)
            {
                Console.WriteLine();
            }
            else if (medium > 1 || medium <= 3)
            {
                Console.WriteLine("Вам потребуются упаковки: " + "Medium: " + medium);
            }

            if (small == 0)
            {
                Console.WriteLine();
            }
            else if(small >= 1 || small <= 4)
                {
                    Console.WriteLine("Вам потребуются упаковки: " + "small: " + small);
                }
                        
        }
        
    }
}
