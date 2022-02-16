using System;

namespace Task_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Гуркова Ирина");
            Type type = typeof(DateTime);
            var properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine("Name={0}", properties[i].Name);
            }
            
        }
    }
}