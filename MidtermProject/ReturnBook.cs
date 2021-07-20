using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermProject
{
    class ReturnBook
    {
        public List<Book> Return(List<Book> books, string input)
        {

            var resultsReturn = books.Where(book => book.Title == input || book.Author == input).ToList();

            foreach (var book in resultsReturn)
            {
                if (input == book.Title && book.InLibrary == BookStatus.Checked_Out || input == book.Author && book.InLibrary == BookStatus.Checked_Out)
                {
                    Console.WriteLine($"Thank you for returning {book.Title}");
                }
                else
                {
                    Console.WriteLine($"{book.Title} is not checked out, did you steal this book?");
                }
            }
            return resultsReturn;

        }
    }
}
