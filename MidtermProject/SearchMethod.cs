using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MidtermProject
{
    public class SearchMethod
    {

        public List<Book> Titles(List<Book> books, string input)
        {
            
            var results = books.Where(book => book.Title == input | book.Author == input).ToList();


            foreach (var book in results)
            {
                if (input == book.Title | input == book.Author && book.InLibrary == true)
                {
                    Console.WriteLine($" Thank you for checking out {book.Title}, please return the book on {book.DueDate.AddDays(14)}");
                }
                else if (input == book.Title | input == book.Author && book.InLibrary == false)
                {
                    Console.WriteLine($"{book.Title} is not available, it will be returned on {book.DueDate}");
                }
            }
            return results;
        }
    }
}
