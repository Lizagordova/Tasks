using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию:");
            string lastName = Console.ReadLine();
            Console.Write("Введите рост:");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите вес:");
            int weight = int.Parse(Console.ReadLine());
            // склеивание
            string info = "Имя:" + firstName + "; фамилия:" + lastName + "; рост:" + height + "; вес:" + weight;
            Console.WriteLine("Cклеивание:");
            Console.WriteLine(info);
            // форматированный вывод
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine("Имя: {0}; фамилия: {1}; рост: {2}; вес: {3}", firstName, lastName, height, weight);
            // вывод со знаком $
            Console.WriteLine("Вывод со знаком $:");
            Console.WriteLine($"Имя:{firstName}; фамилия:{lastName}; рост={height}; вес={weight}");
        }
    }
}