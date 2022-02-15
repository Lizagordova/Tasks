using System;
using System.IO;

namespace Task_4_2
{
    static class StaticClass
    {
        public static int ComputeCountPairs(int [] arr)
        {
            int countPairs = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i+1 < arr.Length) && ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0)))
                {
                    countPairs++;
                }
            }

            return countPairs;
        }

        public static int[] ReadArrayFromTextFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] strings = File.ReadAllLines(filename);
                int[] arr = new int[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                    arr[i] = int.Parse(strings[i]);
                return arr;
            }
            else
            {
                return Array.Empty<int>();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\git\Tasks\Task-4-2\array.txt";
            int[] array = StaticClass.ReadArrayFromTextFile(path);
            int countPairs = StaticClass.ComputeCountPairs(array);
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3: {0}", countPairs);
        }
    }
}