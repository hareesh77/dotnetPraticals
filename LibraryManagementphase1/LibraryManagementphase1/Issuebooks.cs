using System;


namespace LibraryManagementphase1
{
    class Issuebooks
    {
        public int Studentid { get; set; }
        public int Bookid { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Issuebooks(int studentid, int bookid, DateTime issueDate, DateTime returnDate)
        {
            this.Studentid = studentid;
            this.Bookid = bookid;
            this.IssueDate = issueDate;
            this.ReturnDate = returnDate;
        }

        public Issuebooks()
        {
        }

        public Issuebooks(int studentid, int bookid)
        {
           this.Studentid = studentid;
            this.Bookid = bookid;
        }
    }
}
