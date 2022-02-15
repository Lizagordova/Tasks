using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2:");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:F2}", r);
        }
    }
}