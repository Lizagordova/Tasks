using System;

namespace Task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите 3-е число:");
            double c = double.Parse(Console.ReadLine());
            double min = a;
            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }
            Console.WriteLine("Минимальное число: {0}", min);
        }
    }
}