﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Task_6_3_a
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university,
            string faculty, string department, int course,int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0],s[1],s[2],s[3],s[4],int.Parse(s[5]),int.Parse(s[6]),int.Parse(s[7]),s[8]));
                    if (int.Parse(s[5]) == 5 || int.Parse(s[5]) == 6) count++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов на 5 и 6 курсах:" + count);
            Console.ReadKey();
        }
    }
}