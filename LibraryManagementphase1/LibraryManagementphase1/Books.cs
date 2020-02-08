using System;

namespace LibraryManagementphase1
{
   public  class Books
    {
        public int Bookid { get; set; }
        public String Title { get; set; }
        public String Author{ get; set; }

        public Books(int bookid, String title, String author)
        {
            this.Bookid = bookid;
            this.Title = title;
            this.Author = author;
        }

        public Books()
        {
        }
    }
}
