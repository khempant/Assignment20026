using System;

namespace LibraryOfBooks
{
    public class Books
    {
        public class Book
        {
            string title;
            string author;
            int pageNumber;
            string isbn13;

            public string Title { get; set; }
            public string Author { get; set; }
            public int PageNumber { get; set; }
            public string Isbn13 { get; set; }

            public Book()
            {
                Title = title;
                Author = author;
                PageNumber = pageNumber;
                Isbn13 = isbn13;
            }
            public override string ToString()
            {
                return $"{Title}-{Author}-{PageNumber}-{Isbn13}";
            }

        }
    }
}
