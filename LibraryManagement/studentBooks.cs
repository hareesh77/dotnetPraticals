using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    class studentBooks : ILibraryOperations
    {
        private int studentId;
        private string booknumer;

        public studentBooks(int studentId, string booknumer, DateTime issueDate, DateTime returnDate)
        {
            this.studentId = studentId;
            this.booknumer = booknumer;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
        }

        public DateTime issueDate { get; set; }
        public DateTime returnDate { get; set; }
        public void addBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void addStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void issueBook(Book book, Student student)
        {
           
        }

        public void renewal()
        {
            throw new NotImplementedException();
        }

        public void returnBook()
        {
            throw new NotImplementedException();
        }

        public void search()
        {
            throw new NotImplementedException();
        }
    }
}
