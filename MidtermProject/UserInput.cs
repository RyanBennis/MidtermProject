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
                //if(input <> 'y' || )
                else if (!ValidateUserInputForBooks(input))
                {
                    Console.WriteLine("You didn't enter a valid book");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public  string doYouWantToContinue()
        {
            string input2;
            do
            {
                Console.WriteLine("Do you wish to continue? (y/n)");
                input2 = Console.ReadLine();
                if (string.IsNullOrEmpty(input2))
                {
                    Console.WriteLine("Invalid input");
                }
            } while (string.IsNullOrEmpty(input2));
            return input2;

        }

        private bool ValidateUserInputForBooks(string message)
        {
            var book = new Book();
            var allBooks = book.DisplayLibrary();
            var result = allBooks.SingleOrDefault(x =>
                                  (x.Author.Equals(message, StringComparison.InvariantCultureIgnoreCase)) ||
                                  x.Title.Equals(message, StringComparison.InvariantCultureIgnoreCase));
            return result != null;
        }
        

    }
}
