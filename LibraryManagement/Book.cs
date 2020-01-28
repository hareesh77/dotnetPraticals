using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    class Book
    {
        private int bookNumber { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        

        public Book(int bookNumber, string bookName, String author)
        {
            this.bookNumber = bookNumber;
            this.bookName = bookName;
            this.author = author;
        }

        public Book()
        {
        }
    }
    }

