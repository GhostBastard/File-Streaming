using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreaming.Models
{
    public class Group
    {
        private int id;
        private string groupName;
        private int course;

        public int GroupId
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string GroupName
        {
            get
            {
                return groupName;
            }

            set
            {
                groupName = value;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }
        public List<Student> listOfStud { get; set; }

        public Group(int groupId, string groupName, int course)
        {
            GroupId = groupId;
            GroupName = groupName;
            Course = course;
        }
        public Group() { }

        

        

    }
}
