using System;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            long number = long.Parse(Console.ReadLine());
            int digitCount = 0;
            while (number > 1)
            {
                number = number / 10;
                digitCount++;
            }
            Console.WriteLine("Количество цифр в числе: {0}", digitCount);
        }
    }
}