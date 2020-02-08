using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementphase1
{
    class BussinessLogic : ILibraryOperations
    {
        public static List<Books> listofbooks = new List<Books>();
        public static List<Student> listofstudent = new List<Student>();
        public static List<Issuebooks> listofissuebooks = new List<Issuebooks>();
        

        //AddBook method adding book details to the listofbooks list
        public int AddBook(Books books)
        {

            int count = 0;
            if(count==0)
            {
                
                listofbooks.Add(books);
                books.Bookid = listofbooks.Count;
               // Console.WriteLine(books.Bookid+" "+books.Title+" "+books.Author);
            }
            return books.Bookid;
        }






        //AddStudent method add the studentdetaisl to the listofstudetn list
        public bool AddStudent(Student student)
        {
            int count = 0;
            foreach(Student uniquestudent in listofstudent)
            {
                if(uniquestudent.Studentid==student.Studentid)
                {
                    count++;
                }
            }
            if(count==0)
            {
                listofstudent.Add(student);
                return true;
            }
            return false;
        }





        //Displaybooks method displays the all books details form the listofbooks list
        public List<Books>  DisplayBooks()
        {
            
            if (listofbooks.Count > 0)
            {
                return listofbooks;
            }
           
                return null;
        }



        //DisplayissueBooks method displays all the issuedbooks form listofissuebooks list
        public List<Issuebooks> DisplayissueBooks()
        {
            if (listofissuebooks.Count > 0)
            {

                return listofissuebooks;
            }
            return null;
        }




        //DisplayStudent method  will Displays all the student details form listofstudent list
        public List<Student> DisplayStudent()
        {
            if (listofstudent.Count > 0)
            {
                return listofstudent;
            }
            return null;
        }




        //Issuebook method will issuing the book after all validation are true ,first it will check the students id's 
        //form listofstudent,if student 'id's is prasent in the listofstudents,it will proceed next step otherwise return flase,
        //if bookid is prasent in listofbooks.it will execute next step otherwise it will return flase
        //if both studentid and bookids are prasent, it will check number books are issued,
        //this method issues only three books
        //
        public bool Issuebook(int studentid, int bookid)
        {
            int studentcount_1 = 0;
            int bookcount_2 = 0;
            //int count_3;

            //verifying the student in listofstudents
            foreach (Student s in listofstudent)
            {
                if (s.Studentid == studentid)
                {
                    studentcount_1++;
                    break;
                }

            }
            //book verification in listofbooks
            if (studentcount_1 > 0)
            {
                foreach (Books b in listofbooks)
                {

                    if (b.Bookid == bookid)
                    {
                        bookcount_2++;
                        break;
                    }

                }
            }
            if (bookcount_2 > 0)
            {
                int searchcount = 0;
                foreach (Issuebooks issuebooks in listofissuebooks)
                {
                    if (issuebooks.Bookid == bookid)
                    {
                        searchcount++;
                        break;
                    }
                }
                if (searchcount == 0) {
                    int count = 0;
                    foreach (Issuebooks issue in listofissuebooks)
                    {
                        if (issue.Studentid == studentid)
                        {
                            count++;
                        }
                    }
                    if (count < 3)
                    {
                        Issuebooks newissue = new Issuebooks(studentid, bookid);
                        DateTime IssueDate = DateTime.Now;
                        newissue.IssueDate = IssueDate;
                        newissue.ReturnDate = IssueDate.AddDays(30);
                        listofissuebooks.Add(newissue);
                        return true;
                    }
                }

            }
            return false;
        }
            
    
    
        //RemoveBook  method remove the book from the listofbook
        public bool RemoveBook(int bookid)
        {
            if (listofbooks.Count > 0)
            {
                foreach (Books removebook in listofbooks)
                {
                    if (removebook.Bookid == bookid)
                    {
                        listofbooks.Remove(removebook);
                        return true;
                    }
                }
            }     
            return false;
        }



        public bool Removestudent(int studentid)
        {
            if (listofstudent.Count > 0)
            {
                foreach (Student removestudent in listofstudent)
                {
                    if (removestudent.Studentid == studentid)
                    {
                        listofstudent.Remove(removestudent);
                        return true;
                    }
                }
            }

            return false;
        }


        public bool RenewalBook(int studentid, int bookid)
        {
            foreach(Issuebooks renewalvalues in listofissuebooks)
            {
                if(renewalvalues.Studentid==studentid && renewalvalues.Bookid==bookid)
                {
                    Issuebooks renewalissue = new Issuebooks(studentid, bookid);
                    renewalvalues.IssueDate = renewalvalues.ReturnDate;
                    renewalvalues.ReturnDate = renewalvalues.IssueDate.AddDays(15);
                    return true;
                }
            }

            return false;
        }


        public bool Returnbook(int studentid,int bookid)
        {
            if (listofissuebooks.Count > 0)
            {
                foreach (Issuebooks removesissuebook in listofissuebooks)
                {
                    if ((removesissuebook.Studentid==studentid) && (removesissuebook.Bookid==bookid))
                    {
                        listofissuebooks.Remove(removesissuebook);
                        return true;
                    }
                }
            }
            return false;

           

        }




        public void SearchBook(String title)
        {
          List<Books> tempList = new List<Books>();
            if (listofbooks.Count > 0)
            { 
                foreach(Books bookcompare in listofbooks)
                {
                    if(bookcompare.Title==title)
                    {
                      
                        tempList.Add(bookcompare);
                    }
                    
                }
                foreach (Books matchedbook in tempList)
                {
                    Console.WriteLine(matchedbook.Bookid + "|" + matchedbook.Title + "|" + matchedbook.Author);
                    
                }
                goto x;
            x: int count ;
                 foreach(Books books in tempList)
                {
                    count = 0;
                    foreach (Issuebooks checkidinissuelist in listofissuebooks)
                    {
                        if(books.Bookid==checkidinissuelist.Bookid)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("bookID's:" + books.Bookid + " " + "is available");
                    }
                    else if(count>0)
                    {
                        Console.WriteLine("bookID's:" + books.Bookid + " " + "is not available");
                    }    
                }

            }
           
            
        }

        public bool Searchstudent(int studentid)
        {
            if (listofstudent.Count > 0)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("Studentid" + "| " + "StudentName" + " |" + "Branch" + " |" + "Yop");
                Console.WriteLine("===========================================");
                foreach (Student searchstudent in listofstudent)
                {

                    if (searchstudent.Studentid == studentid)
                    {
                        Console.WriteLine(searchstudent.Studentid + " |" + searchstudent.StudentName + " |" + searchstudent.Branch + " |" + searchstudent.Yop);
                        return true;

                    }
                }
            }
            return false;
        }
    }
}
