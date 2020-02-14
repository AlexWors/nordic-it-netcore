using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int personCount = 3;
            var personArray = new person[personCount];

            for(int i = 0; i < personArray.Length; i++)
            {
                try
                {
                    //var person = new person();
                    Console.WriteLine($"Введите имя{i + 1}: ");
                    personArray[i].Name = Console.ReadLine();
                    Console.WriteLine($"Введите возраст{i + 1}: ");
                    personArray[i].Age = int.Parse(Console.ReadLine());
                    //personArray[i] = person;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            for(int i = 0; i < personArray.Length; i++)
            {
                Console.WriteLine(personArray[i].Output);
            }
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
