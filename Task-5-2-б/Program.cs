using System;
using System.Text;

namespace Task_5_2_б
{
    static class Message
    {
        public static string RemoveWordsWithSymbol(string message, char symbol)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] strArr = message.Split(' ');
            for (int i=0; i < strArr.Length;i++)
                if (!strArr[i].EndsWith(symbol))
                {
                    stringBuilder.Append(strArr[i]);
                    stringBuilder.Append(" ");
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
            Console.WriteLine("Введите символ:");
            char symbol = char.Parse(Console.ReadLine());
            string str = Message.RemoveWordsWithSymbol(message, symbol);
            Console.WriteLine("{0}", str);
        }
    }
}