using System;

namespace Task_6_1
{
    public delegate double Fun(double x, double a);
    class Program
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }

        public static double MyFuncWithSin(double x, double a)
        {
            return a * Math.Sin(x);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Функция a*sin(x)");
            Table(MyFuncWithSin,-2,2, 4);
            Console.WriteLine("Функция a*x^2");
            Table(MyFunc,-2,2, 3);
        }
    }
}