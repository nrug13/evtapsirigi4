using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { BookName = "Qerb burkusu", AuthorName = "Cingiz Abdullayev", PublishedDate = new DateTime(2013, 12, 4), PageCount=300 };
            Console.WriteLine(book1);
        }
    }
    public class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishedDate { get; set; }
        public int PageCount { get; set; }

        public override string ToString()
        {
            return $" Kitab:{BookName}\n Muelilf:{AuthorName}\n Il:{PublishedDate}\n Sehife:{PageCount}  ";
        }

    }
}
