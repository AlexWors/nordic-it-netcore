using System;
using System.Diagnostics;

namespace ClassWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 50000;       // длина массива
            const int maxValue = 1000000;  // максимальное значение элемента

            int[] arr = GetArray(length, maxValue);
            WriteOutArray(arr, "initial array: ");

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] bubbleArray = GetBubleSortedArray(arr);
            timer.Stop();
            WriteOutArray(bubbleArray, $"Bubble-sorted array ({timer.ElapsedMilliseconds} ms): ");

            
            timer.Restart();
            int[] netCorebubbleArray = GetBubleNetCoreSortedArray(arr);
            timer.Stop();
            WriteOutArray(netCorebubbleArray, $".NET-sorted array ({timer.ElapsedMilliseconds} ms): ");

        }


        static int[] GetArray(int length, int maxValue)
        {
            var arr = new int[length];           // создаем массив с размером равным length
            var rnd = new Random();              // создаем объект генератора случайных чисел

            for (var i = 0; i < arr.Length; i++) // перебираем каждый элемент массива
            {
                arr[i] = rnd.Next(maxValue);     // заполняем его произвольным значением
            }

            return arr;
        }

        static void WriteOutArray(int[] arr, string arrayName)
        {
            Console.WriteLine(arrayName);
            //for (var i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }

        static int[] GetBubleSortedArray(int[] array)
        {
            int[] arr = (int[])array.Clone();
            for (var w = 0; w < arr.Length - 1; w++)
            {
                for (var i = 0; i < arr.Length - 1 - w; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[i + 1];
                        //arr[i + 1] = temp;

                        arr[i] = arr[i] ^ arr[i + 1];
                        arr[i + 1] = arr[i + 1] ^ arr[i];
                        arr[i] = arr[i] ^ arr[i + 1];

                    }
                }
            }
            return arr;
        }

        static int[] GetBubleNetCoreSortedArray(int[] array)
        {
            int[] arr = (int[])array.Clone();
            Array.Sort(arr);
            return arr;
        }


    }
}

