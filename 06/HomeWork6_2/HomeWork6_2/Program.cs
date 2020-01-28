using System;

namespace HomeWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal initialFee = 0;
            decimal percent = 0;
            decimal sum = 0;
            do
            {


                try
                {
                    Console.WriteLine("Введите сумму первоначального взноса в рублях: ");
                    initialFee = decimal.Parse(Console.ReadLine());
                    if (initialFee <= 0)
                    {
                        Console.WriteLine("Сумма взноса должна быть больше нуля!");
                        continue;
                    }
                    Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби(1 % = 0.01): ");
                    percent = decimal.Parse(Console.ReadLine());
                    if(percent <= 0)
                    {
                        Console.WriteLine("Процент дохода должен быть больше нуля!");
                        continue;
                    }
                    Console.WriteLine("Введите желаемую сумму накопления в рублях: ");
                    sum = decimal.Parse(Console.ReadLine());
                    if (sum <= 0 || sum <= initialFee)
                    {
                        Console.WriteLine("Желаемая сумма должена быть больше нуля и больше первоначального взноса!");
                        
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода, попробуйте еще раз!");
                }
            } while (initialFee <= 0 || percent <= 0 || sum <= 0 || sum <= initialFee);
            int days = 0;
            while(initialFee <= sum)
            {
                initialFee += initialFee * percent;
                days++;
            }
            Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы: {days}");
        }
    }
}
