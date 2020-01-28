using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book 
            operationsImplementation allmethod = new operationsImplementation();
           // string input1 = Console.ReadLine();
            while (true)
            { 

                Console.WriteLine("Welcome to Library Managent System");
                Console.WriteLine("enter the 1 to addBook");
                Console.WriteLine("enter the 2 to addStudent");
                Console.WriteLine("enter the 0 to addBook");
                Console.WriteLine("enter the 3 to issueBook");
                int input = Int32.Parse(Console.ReadLine());



                if (input == 1)
                {
                    Console.WriteLine("enter the Bookid");
                    int bookNumber = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter the BookName");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("enter the author");
                    string author = Console.ReadLine();
                    Book book = new Book(bookNumber, bookName, author);

                    allmethod.addBook(book);


                }
                else if (input == 2)
                {
                    //student

                    Console.WriteLine("enter the studentId");
                    int studentId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter the studentName");
                    string sName = Console.ReadLine();
                    Console.WriteLine("enter the Branch");
                    string branch = Console.ReadLine();
                    Console.WriteLine("enter the year of passedout student");
                    int yop = Int32.Parse(Console.ReadLine());
                    Student addstudent = new Student(studentId, sName, branch, yop);
                    allmethod.addStudent(addstudent);
                }



                else if (input == 3)
                {
                    //issueBook

                    Console.WriteLine("enter the studentId");
                    int studentId = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter the BookId");
                    string booknumer = Console.ReadLine();
                    Console.WriteLine("IssueDate");
                    DateTime issueDate = DateTime.Now;
                    Console.WriteLine("returnDate");
                    DateTime ReturnDate = issueDate.AddDays(30);
                    studentBooks studentbooks = new studentBooks(studentId, booknumer, issueDate, ReturnDate);
                    allmethod.issueBook(studentbooks);
                }
                else if (input == 0)
                {
                    Console.WriteLine("thanks for coming");
                    break;
                }
            }
        }
    }
}
