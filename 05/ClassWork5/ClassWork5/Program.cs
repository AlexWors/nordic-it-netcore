﻿using System;

namespace ClassWork5
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //int a, b, c;
            //try
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(a / b);

            //}
            //catch(FormatException e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Введены некорректные данные");
            //    Console.ResetColor();
                
            //}
            
            //catch(DivideByZeroException e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Нельзя делить на ноль");
            //    Console.ResetColor();
                
            //}
            //catch(Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Неизвестная ошибка");
            //    Console.ResetColor();
            //    throw;
            //}
            //finally
            //{
            //    Console.WriteLine("finally block here");
            //    Environment.Exit(-1);
            //}


            Console.WriteLine("Введите длительность договора аренды в годах: ");
            int years = int.Parse(Console.ReadLine());
            string message = string.Empty;
            
            switch (years)
            {
                case 1:
                case 21:      
                    message = $"Договор аренды оформлен на период длительностью {years} год";
                    break;
                case 2:
                case 3:
                case 4:
                case 22:
                case 23:
                case 24:
                    message = $"Договор аренды оформлен на период длительностью {years} года";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    message = $"Договор аренды оформлен на период длительностью {years} лет";
                    break;
                default:
                    throw new Exception("Вы ввели неверное значение!");
                    break;
            }
            Console.WriteLine(message);







            //Console.WriteLine("Введите длительность договора аренды в годах: ");
            //int years = int.Parse(Console.ReadLine());
            //string message = string.Empty;
            ////1 21 год
            //if (years == 1 || years == 21)
            //{
            //    message = $"Договор аренды оформлен на период длительностью {years} год";
            //}
            ////2 3 4 22 23 24 года
            //else if ((years >= 2 && years <= 4) || (years >= 22 && years <= 24))
            //{
            //    message = $"Договор аренды оформлен на период длительностью {years} года";
            //}
            ////5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 25 26 27 28 29 30 лет
            //else if ((years >= 5 && years <= 20) || (years >= 25 && years <= 30))
            //{
            //    message = $"Договор аренды оформлен на период длительностью {years} лет";
            //}
            //else if (years > 30 || years <= 0)
            //{
            //    throw new Exception("Вы ввели неверное значение!");

            //}
            //Console.WriteLine(message);


        }
    }
}
