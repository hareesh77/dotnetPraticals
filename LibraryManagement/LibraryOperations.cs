using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    interface ILibraryOperations
    {
        void addBook(Book book);
        void addStudent(Student student);
        void search();
        void issueBook(Book book,Student student);
        void returnBook();
        void renewal();
    }
}
