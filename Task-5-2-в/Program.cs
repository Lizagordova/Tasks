using System;
using System.Text;

namespace Task_5_2_в
{
    static class Message
    {
        public static string FindLongWord(string message)
        {
            string[] strArr = message.Split(' ');
            int max = 0;
            int imax = 0;
            for (int i=0; i < strArr.Length;i++)
                if (strArr[i].Length >= max)
                {
                    max = strArr[i].Length;
                    imax = i;
                }

            return strArr[imax];
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();
            string word = Message.FindLongWord(message);
            Console.WriteLine("Самое длинное слово: {0}", word);
        }
    }
}