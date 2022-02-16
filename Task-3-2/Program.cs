using System;

namespace Task_3_2
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
            int number;
            bool flag;
            double sum = 0;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);
                if (flag && IsOdd(number) && IsPositive(number))
                {
                    sum = sum + number;
                }
            } while (number !=  -1);
            Console.WriteLine("Сумма нечётных положительных чисел: {0}", sum);
        }
    }
}