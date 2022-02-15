using System;
using System.Linq;

namespace Task_5_1
{
    class Program
    {
        static bool IsValidLogin(string login)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' , 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'r', 's', 't', 'v', 'x', 'y', 'z' };
            if (login.Length < 2 && login.Length > 10)
            {
                return false;
            }
            if (char.IsDigit(login[0]))
            {
                return false;
            }

            for (int i = 1; i < login.Length; i++)
            {
                if (!char.IsDigit(login[i]) && !alphabet.Contains(login[i]))
                {
                    return false;
                }
            }

            return true;
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