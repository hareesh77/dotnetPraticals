using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    class Student
    {
        private int studentId { get; set; }
        public String sName { get; set; }
        public string branch { get; set; }
        public int yop { get; set; }

        public Student(int studentId, String sName, string branch, int year)
        {
            this.studentId = studentId;
            this.sName = sName;
            this.branch = branch;
            this.yop = yop;
        }

        public Student()
        {
        }
    }
}
