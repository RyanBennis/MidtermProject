using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MidtermProject
{
    public class UserInput
    {
        public string GetUserInput(string message)
        {
            string input;
            do
            {
                
                Console.WriteLine(message);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input");
                }
                else if (!ValidateUserInputForBooks(input))
                {
                    Console.WriteLine("You didn't enter a valid book");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
        private bool ValidateUserInputForBooks(string message)
        {
            var book = new Book();
            var allBooks = book.DisplayLibrary();
            var result = allBooks.SingleOrDefault(x =>
                                  x.Author == message ||
                                  x.Title == message);
            return result != null;
        }
        

    }
}
