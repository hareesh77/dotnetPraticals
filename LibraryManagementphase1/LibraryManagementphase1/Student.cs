using System;
namespace LibraryManagementphase1
{
    class Student
    {
        public int Studentid { get; set; }
        public String StudentName { get; set; }
        public String Branch { get; set; }
        public long Yop { get; set; }

        public Student(int studentid, string studentName, string branch, long yop)
        {
            this.Studentid = studentid;
            this.StudentName = studentName;
            this.Branch = branch;
            this.Yop = yop;
        }
    }
}
