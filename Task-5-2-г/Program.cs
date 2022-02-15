using System;
using System.Text;

namespace Task_5_2_г
{
    static class Message
    {
        public static string FindLongWords(string message)
        {
            string[] strArr = message.Split(' ');
            int max = 0;
            int imax = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length >= max)
                {
                    max = strArr[i].Length;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length == max)
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
            string word = Message.FindLongWords(message);
            Console.WriteLine("Самое длинные слова: \n {0}", word);
        }
    }
}