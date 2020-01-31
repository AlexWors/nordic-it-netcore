using System;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] words = new string[1];
            while (words.Length < 2)
            {
                try
                {
                    Console.WriteLine("Введите строку из нескольких слов: ");
                    str = Console.ReadLine();
                    words = str.Split(' ');
                    if (words.Length < 2)
                    {
                        throw new Exception("Слишком мало слов :( Попробуйте ещё раз: ");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var count = 0;
            foreach(var word in words)
                if(word.StartsWith("А", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            Console.WriteLine($" Количество слов, начинающихся с буквы 'А': {count}");
        }
    }
}
