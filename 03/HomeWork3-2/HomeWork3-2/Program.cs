using System;

namespace HomeWork3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    mas[i, j] = i * j;
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine("\n"); 
                
            }
            
        }
    }
}
