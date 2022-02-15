using System;

namespace Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-10000, 10000);
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(" {0} ", array[i]);
            Console.WriteLine();
            int countPairs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i+1 < array.Length) && ((array[i] % 3 == 0 && array[i + 1] % 3 != 0) || (array[i] % 3 != 0 && array[i + 1] % 3 == 0)))
                {
                    countPairs++;
                }
            }
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3: {0}", countPairs);
        }
    }
}