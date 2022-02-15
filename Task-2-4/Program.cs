using System;

namespace Task_2_4
{
    class Program
    {
        static bool IsValidPassword(string password)
        {
            return password == "GeekBrains";
        }

        static bool IsValidLogin(string login)
        {
            return login == "root";
        }
        
        static void Main(string[] args)
        {
            int attemptsCount = 0;
            bool authorized = false;
            do
            {
                Console.Write("Введите логин:");
                string login = Console.ReadLine();
                Console.Write("Введите пароль:");
                string password = Console.ReadLine();
                if (IsValidLogin(login) && IsValidPassword(password))
                {
                    authorized = true;
                    break;
                }
                attemptsCount++;
            } while (attemptsCount < 3);

            if (authorized)
            {
                Console.WriteLine("Вы успешно прошли авторизацию");
            }
            else
            {
                Console.WriteLine("Вы не прошли авторизацию");
            }
        }
    }
}