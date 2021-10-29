using System;
using System.Collections.Generic;
using FileStreaming.Models;
using System.IO;

namespace FileStreaming
{
    class Program
    {
        static void WriteInfo(string path, Group group)
        {
            bool rewrite = false;
            Console.WriteLine(@"Rewrite file?(y\n)");
            char x = Convert.ToChar(Console.ReadLine());
            if(x == 'y'){ rewrite = false; }
            else if (x == 'n'){rewrite = true;}
            using (StreamWriter sw = new StreamWriter(path, rewrite))
            {
                sw.WriteLine($"Group: {group.GroupName} {group.GroupId}, course - {group.Course}");
                foreach (Student st in group.listOfStud) { sw.WriteLine(st); }
            }
        }

        static void Main(string[] args)
        {
            Group group = new Group(11, "BSD", 1);
            group.listOfStud = new List<Student>();
            group.listOfStud.Add(new Student(1, "al", "mak", "123", "123@mail.com", 11));
            group.listOfStud.Add(new Student(2, "al", "mak", "123", "123@mail.com", 11));
            group.listOfStud.Add(new Student(3, "al", "mak", "123", "123@mail.com", 11));
            group.listOfStud.Add(new Student(4, "al", "mak", "123", "123@mail.com", 11));
            group.listOfStud.Add(new Student(5, "al", "mak", "123", "123@mail.com", 11));

            string path = @"C:\Users\Aleksandr\Desktop\groups.txt";

            WriteInfo(path, group);
            

            group = new Group(43, "SZD", 4);
            group.listOfStud = new List<Student>();
            group.listOfStud.Add(new Student(1, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(2, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(3, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(4, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(5, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));

            WriteInfo(path, group);

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.ReadKey();

            

            
            

            
            
        }
    }
}
