using System;
using System.Collections.Generic;
using FileStreaming.Models;
using System.IO;

namespace FileStreaming
{
    class Program
    {
        static byte[] WriteGroupInfo(Group group, out int arrLen)
        {
            string groupInfo = $"Group: {group.GroupName} {group.GroupId}, course - {group.Course}\n";
            byte[] array = System.Text.Encoding.Default.GetBytes(groupInfo);
            arrLen = array.Length;
            return array;
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

            
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                string Text;
                int arrLen;
                fileStream.Write(WriteGroupInfo(group, out arrLen), 0, arrLen);
                foreach (Student st in group.listOfStud)
                {
                    Text = st.ToString() + "\n";
                    byte[] array = System.Text.Encoding.Default.GetBytes(Text);
                    fileStream.Write(array, 0, array.Length);
                }
            }

            group = new Group(43, "SZD", 4);
            group.listOfStud = new List<Student>();
            group.listOfStud.Add(new Student(1, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(2, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(3, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(4, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));
            group.listOfStud.Add(new Student(5, "Aleksandr", "Makarchenko", "1234567", "qweth@mail.com", 43));

            

            using (FileStream fileStream = new FileStream(path, FileMode.Append))
            {
                string Text;
                int arrLen;
                fileStream.Write(WriteGroupInfo(group, out arrLen), 0, arrLen);
                foreach (Student st in group.listOfStud)
                {
                    Text = st.ToString() + "\n";
                    byte[] array = System.Text.Encoding.Default.GetBytes(Text);
                    fileStream.Write(array, 0, array.Length);
                }
            }

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] array = new byte[fileStream.Length];
                fileStream.Read(array, 0, array.Length);
                string data = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"{data}");
            }

            Console.ReadLine();








        }
    }
}
