using System;

namespace Task_2_3
{
    class Program
    {
        static bool IsOdd(double n)
        {
            return n % 2 == 1;
        }

        static bool IsPositive(double n)
        {
            return n > 0;
        }
        
        static void Main(string[] args)
        {
            double number = -1;
            double sum = 0;
            while (number != 0)
            {
                Console.Write("Введите число:");
                number = double.Parse(Console.ReadLine());
                if (IsOdd(number) && IsPositive(number))
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine("Сумма нечётных положительных чисел: {0}", sum);
        }
    }
}