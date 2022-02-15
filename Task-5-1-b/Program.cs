using System;
using System.Text.RegularExpressions;

namespace Task_5_1_b
{
    class Program
    {
        static bool IsValidLogin(string login)
        {
            Regex regex = new Regex("^[A-Za-z][A-Za-z0-9]{1,9}");
            return regex.IsMatch(login);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            var valid = IsValidLogin(login);
            if (valid)
            {
                Console.WriteLine("Логин корректный.");
            }
            else
            {
                Console.WriteLine("Логин некорректный.");
            }
        }
    }
}