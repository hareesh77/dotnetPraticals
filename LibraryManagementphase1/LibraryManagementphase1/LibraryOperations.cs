using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementphase1
{
    
    interface ILibraryOperations
    {
        
      //add Book
        int AddBook(Books books);
        bool AddStudent(Student student);


        //Display methods
       List<Books> DisplayBooks();

        List<Student> DisplayStudent();



       // search methods
        void SearchBook(String Title);
         bool Searchstudent(int studentid);



        //remove methods
        bool RemoveBook(int bookid);
        bool Removestudent(int studentid);

        // issue books

        bool Issuebook(int studentid,int bookid);
        List<Issuebooks> DisplayissueBooks();
        bool Returnbook(int studentid,int bookid);
        bool RenewalBook(int studentid, int bookid);
         

    }
}
