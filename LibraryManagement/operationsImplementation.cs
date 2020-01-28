using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement
{
    class operationsImplementation : ILibraryOperations
    {
        SortedSet<Book> sortbook = new SortedSet<Book>();
        SortedSet<Student> studentset = new SortedSet<Student>();
        
        public void addBook(Book book)
        {
            sortbook.Add(book);
           
        }

        public void issueBook(studentBooks studentbooks)
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

        public void addStudent(Student student)
        {
            studentset.Add(student);
            Console.WriteLine(studentset.Count);
           
        }

        public void issueBook(Book book, Student student)
        {
            throw new NotImplementedException();
        }
    }
    }

