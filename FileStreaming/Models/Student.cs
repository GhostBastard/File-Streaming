using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreaming.Models
{
    public class Student : Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public new int GroupId { get; set; }

        public Student(int id, string firName, string secName, string phoneNumber, string email, int groupId)
        {

            Id = id;
            Name = firName;
            Surname = secName;
            PhoneNumber = phoneNumber;
            Email = email;
            GroupId = groupId;
        }
        public Student() { }

        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Surname: " + Surname + ", Phone: " + PhoneNumber + ", Email: " + Email + ", Group id: " + GroupId;
        }

    }
}
