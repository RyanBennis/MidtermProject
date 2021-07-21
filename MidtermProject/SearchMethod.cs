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
            
            var results = books.Where(book => book.Title == input || book.Author == input).ToList();


            foreach (var book in results)
            {
                if (input == book.Title && book.InLibrary == BookStatus.On_Shelf || input == book.Author && book.InLibrary == BookStatus.On_Shelf)
                {
                    Console.WriteLine($" Thank you for checking out {book.Title}, please return the book on {book.DueDate.AddDays(14)}");
                    book.InLibrary = BookStatus.Checked_Out;
                    book.DueDate = DateTime.Today.AddDays(14);
                }
                else if (input == book.Title && book.InLibrary == BookStatus.Overdue || input == book.Author && book.InLibrary == BookStatus.Overdue)
                {
                    Console.WriteLine($"{book.Title} is not available, it was due to be returned on {book.DueDate}");
                    if (book.DueDate >= DateTime.Today)
                    {
                        book.InLibrary = BookStatus.Overdue;
                        Console.WriteLine($"{book.Title} is not available, it was due to be returned on {book.DueDate}");

                    }
                    else if (book.InLibrary == BookStatus.Overdue)
                    {
                        Console.WriteLine($"{book.Title} is not available, it was due to be returned on {book.DueDate}");

                    }

                }
                else if (input == book.Title && book.InLibrary == BookStatus.Lost || input == book.Author && book.InLibrary == BookStatus.Lost)
                {
                    Console.WriteLine($"{book.Title} is not available, it has been Lost or Misplaced");
                }
                else 
                {
                    Console.WriteLine($"{book.Title} is not available, it will be returned on {book.DueDate}");
                }
            }
            return results;
        }
    }
}
