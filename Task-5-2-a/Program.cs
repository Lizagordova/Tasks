using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_5_2
{
    static class Message
    {
        public static string NotMoreThanNLetters(int n, string message)
        {
            Regex regex = new Regex(@"^[A-Za-z]+$");
            StringBuilder stringBuilder = new StringBuilder();
            string[] strArr = message.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length <= n && regex.IsMatch(strArr[i]))
                {
                    stringBuilder.Append(strArr[i]);
                    stringBuilder.Append(" ");
                }
            }

            return stringBuilder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            string str = Message.NotMoreThanNLetters(n, message);
            Console.WriteLine("{0}", str);
        }
    }
}