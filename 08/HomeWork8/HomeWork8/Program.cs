using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Введите строку из следующих скобок: (, ), [, ].");
			string input;
			
				do
				{
					input = Console.ReadLine();
					if (input != string.Empty || input == "(" || input == ")" || input == "[" || input == "]")
					{
						break;
					}
					else
					{
						Console.WriteLine("вы ввели пустую строку или иные символы!");
						continue;
					}

				} while (true);

			char[] charArray = input.ToCharArray();

			var charDictionary = new Dictionary<char, char>();
			charDictionary.Add(')', '(');
			charDictionary.Add(']', '[');

			var Stack = new Stack<char>();
			for (int i = 0; i < charArray.Length; i++)
			{
				Console.WriteLine(charArray[i]);
				if(charDictionary.ContainsValue(charArray[i]))
				{
					Stack.Push(charArray[i]);
				}
				else if (charDictionary.ContainsKey(charArray[i]))
				{
					if(Stack.Count > 0 && Stack.Peek() == charDictionary[charArray[i]])
					{
						Stack.Pop();
					}
					else
					{
						Console.WriteLine(false);
						Environment.Exit(-1);

					}

				}
			}
			if (Stack.Count > 0)
			{
				Console.WriteLine(false);
			}
			else
			{
				Console.WriteLine(true);
			}
		}
    }
}
