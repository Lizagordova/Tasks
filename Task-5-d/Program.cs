using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_5_d
{
    static class Message
    {
        public static Dictionary<string, int> FindWordsFrequency(string message, string[] array)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] messageArray = message.Split(' ');
            for (int i = 0; i < messageArray.Length; i++)
            {
                if (array.Contains(messageArray[i]))
                {
                    if (dictionary.ContainsKey(messageArray[i]) == false)
                    {
                        dictionary.Add(messageArray[i], 1);
                    }
                    else
                    {
                        dictionary[messageArray[i]]++;
                    }
                }
            }

            return dictionary;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();
            Console.WriteLine("Введите массив через пробел:");
            string[] array = Console.ReadLine().Split(' ');
            Dictionary<string, int> wordsFrequency = Message.FindWordsFrequency(message, array);
            foreach (var wordFrequency in wordsFrequency)
            {
                Console.WriteLine("Слово {0} встречается {1} раз", wordFrequency.Key, wordFrequency.Value);
            }
        }
    }
}