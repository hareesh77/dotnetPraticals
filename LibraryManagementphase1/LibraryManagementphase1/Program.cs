using System;
using System.Collections.Generic;

namespace LibraryManagementphase1
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessLogic bussinesslogic = new BussinessLogic();
            
            while (true) {


                Console.WriteLine("Welcome to Library Managent System");
                Console.WriteLine("Enter  1 to addBook");
                Console.WriteLine("Enter  2 to DisplayBooks");
                Console.WriteLine("Enter  3 to SearchBook");
                Console.WriteLine("Enter  4 to Removing book");
                Console.WriteLine("Enter  5 to AddStudent");
                Console.WriteLine("Enter  6 to DisplayStudent");
                Console.WriteLine("Enter  7 to SearchStudent");
                Console.WriteLine("Enter  8 to RemoveStudent");
                Console.WriteLine("Enter  9 to Issuebook");
                Console.WriteLine("Enter  10 to DisplayIssueBooks");
                Console.WriteLine("Enter  11 to Returnbook");
                Console.WriteLine("Enter  12 to Renewal book");
                Console.WriteLine("Enter  0 to exit\n");
                Console.WriteLine("please type input and press Enter key");
                int input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {

                    int bookid = 1;
                    Console.WriteLine("enter the BookName");
                    string booktitle = Console.ReadLine();
                    Console.WriteLine("enter the author");
                    string author = Console.ReadLine();
                    Books book = new Books(bookid, booktitle, author);
                    int autoId = bussinesslogic.AddBook(book);
                    //bookid = autoId;
                    Console.WriteLine("you bookId is:" + autoId);

                }
                else if (input == 2)
                {
                   List<Books> displaybook= bussinesslogic.DisplayBooks();
                    if(displaybook!=null)
                    {
                        Console.WriteLine("==========================================");
                        Console.WriteLine("Bookid" + "| " + "Title" + " |" + "author");
                        Console.WriteLine("===========================================");
                        foreach(Books books in displaybook)
                        {
                            Console.WriteLine(books.Bookid + "|" + books.Title + "|" + books.Author);
                        }
                    }
                    else
                    {
                        Console.WriteLine("booklist is empty");
                    }
                     /*foreach (Books book in displaybook)
                     { 
                    Console.WriteLine(book.Bookid + " " + book.Title + " " + book.Author);
                     }*/
                }

                else if (input == 3)
                {
                    Console.WriteLine("Enter title or name of the book for searching");
                    String title = Console.ReadLine();
                    Console.WriteLine("\n");
                    bussinesslogic.SearchBook(title);
                    Console.WriteLine("\n");
                }


                else if (input == 4)
                {
                    Console.WriteLine("Enter bookid for removing");
                    int bookid = int.Parse(Console.ReadLine());
                    bool removevalue = bussinesslogic.RemoveBook(bookid);
                    if (removevalue == true)
                    {
                        Console.WriteLine(removevalue);
                    }
                    else
                    {
                        Console.WriteLine(removevalue);
                        Console.WriteLine("'sorry empty booklist\t add book and remove'");
                    }
                }
                else if (input == 5)
                {
                    Console.WriteLine("enter year of joining");
                    long year = long.Parse(Console.ReadLine());
                    if (year >= 2020 && year <= 2024)
                    {
                        Console.WriteLine("enter the studentId");                           //Add student 2
                        int Studentid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("enter the studentName");
                        string StudentName = Console.ReadLine();
                       Console.WriteLine("enter the Branch");
                        string Branch = Console.ReadLine();
                        long Yop = year + 4;
                        Student addstudent = new Student(Studentid, StudentName, Branch, Yop);
                        bool addresult = bussinesslogic.AddStudent(addstudent);
                        if (addresult == false)
                        {
                            Console.WriteLine("added book is:" + addresult);
                            Console.WriteLine("your enter id is alredy existed\n please enter unique id");
                        }
                        else
                        {
                            Console.WriteLine("added book is:" + addresult);
                        }
                    }


                    else
                    {
                        Console.WriteLine("please enter between year of 2020 and 2024");
                    }

                }
                else if (input == 6)
                {
                   List<Student> displaystudents= bussinesslogic.DisplayStudent();
                    if(displaystudents!=null)
                    {
                        Console.WriteLine("==============================================================");
                        Console.WriteLine("Studentid" + "| " + "Studetname" + " |" + "Branch" + "|" + "YOP");
                        Console.WriteLine("===============================================================");
                        foreach(Student student in displaystudents)
                        {
                            Console.WriteLine(student.Studentid + "|" + student.StudentName + "|" + student.Branch + "|" + student.Yop);  
                        }
                    }
                    else
                    {
                        Console.WriteLine("no students in listofstudents  list");
                    }
                }


                else if (input == 7)
                {
                    Console.WriteLine("Enter studentid for searching");
                    int studentid = int.Parse(Console.ReadLine());
                    bool serachvalue=bussinesslogic.Searchstudent(studentid);
                    
                    if(serachvalue==true)
                    {
                        Console.WriteLine("studetnid is found in StudentList:"+ serachvalue);
                    }
                    else
                    {
                        Console.WriteLine(serachvalue);
                        Console.WriteLine("studentList is empty");

                    }
                }
                else if (input == 8)
                {
                    Console.WriteLine("Enter studentid for removing");
                    int removeid = int.Parse(Console.ReadLine());
                    bool removevalue = bussinesslogic.Removestudent(removeid);
                    if (removevalue == false) 
                    { Console.WriteLine("student is removed:" + removevalue);
                        Console.WriteLine("sorrystudets are not existed\n please add students to studentlist");
                    }
                    else
                    {
                        Console.WriteLine(removevalue);
                        
                    }
                }


                else if (input == 9)
                {
                    Console.WriteLine("enter studentid for issuebook");
                    int studentid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter bookid for issuebook");
                    int bookid = int.Parse(Console.ReadLine());
                    bool issuereturnvalue = bussinesslogic.Issuebook(studentid, bookid);
                    Console.WriteLine("Book is issued:" + issuereturnvalue);

                }

                else if (input == 10)
                {
                    List<Issuebooks> displayissuebooks=bussinesslogic.DisplayissueBooks();
                    if(displayissuebooks!=null)
                    {
                        Console.WriteLine("==============================================================");
                        Console.WriteLine("Studentid" + "| " + "bookid" + " |" + "issueDate" + "|" + "returnDate");
                        Console.WriteLine("===============================================================");
                        foreach(Issuebooks issuebooks in displayissuebooks)
                        {
                            Console.WriteLine(issuebooks.Studentid + "|" + issuebooks.Bookid + "|" + issuebooks.IssueDate + "|" + issuebooks.ReturnDate);
                        }
                    }else
                    {
                        Console.WriteLine("no book is issued as  of now");
                    }

                }


                else if (input == 11)
                {
                    Console.WriteLine("enter studentid for Returnbook");
                    int studentid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter bookid for issuebook");
                    int bookid = int.Parse(Console.ReadLine());
                    bool issvalue = bussinesslogic.Returnbook(studentid, bookid);
                    
                    if(issvalue==true)
                    {
                        Console.WriteLine("Return books:" + issvalue);
                    }
                    else
                    {
                        Console.WriteLine("Return books:" + issvalue);
                       Console.WriteLine("sorry books are not existed\n please add books to booklist");
                    }


                }
                else if (input == 12)
                {
                    Console.WriteLine("enter studentid for renewal book");
                    int studentid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter bookid for renewal book");
                    int bookid = int.Parse(Console.ReadLine());
                    bool issuereturnvalue = bussinesslogic.RenewalBook(studentid, bookid);
                    Console.WriteLine("Book  renewal is:" + issuereturnvalue);

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

