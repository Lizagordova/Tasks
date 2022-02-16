using System;

namespace Task3
{
    class Program
    {
        static double computeR(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

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
            double r = computeR(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между точками: {0:F2}", r);
        }
    }
}