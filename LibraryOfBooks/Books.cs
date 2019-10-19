using System;

namespace LibraryOfBooks
{
       public class Books
        {
            string title;
            string author;
            int pageNumber;
            string isbn13;

            public string Title { get; set; }
            public string Author { get; set; }
            public int PageNumber { get; set; }
            public string Isbn13 { get; set; }

            public Books(string title, string author, int PageNumber, string isbn13)
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

