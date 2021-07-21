using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueFlag;
            Console.WriteLine("Welcome to our Library, We are happy you are here");

            var libraryName = "CurrentBookList.txt";

            //For Reading from a file

            var books = FileIO.ReadFromFile(libraryName);


            //For Creating a File

            //var library = new Book();
            //var books = library.DisplayLibrary();
            //FileIO.CreateFile(libraryName);

            do
            {
                Console.WriteLine("Here are the books that we have in our Library");   
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }

                Console.WriteLine("\n\rThere are a few things you can do here:\n\r");
                Console.WriteLine("1. Checkout a book");
                Console.WriteLine("2. Return a book");
                Console.WriteLine("3. Add a book to the library\n\r");
                var uI = new UserInput();
                string userInput = uI.GetUserInput("Please choose a number");

                if (userInput == "1")
                {
                    string searchAuthor = uI.GetUserInput("Please enter the name of a book or an Author:");
                    var searchMethod = new SearchMethod();
                    var searchedBooks = searchMethod.Titles(books, searchAuthor);
                }
                else if (userInput == "2")
                {
                    string searchAuthor2 = uI.GetUserInput("Please enter the name of the book you are returning:");
                    var returnBook = new ReturnBook();
                    var returnbooks = returnBook.Return(books, searchAuthor2);
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Work in Progress");
                }
                else
                {
                    Console.WriteLine("That is not a valid response");
                }
                var userInput1 = new UserInput();
                continueFlag = userInput1.GetUserInput("Do you want to continue (y/n)");
            } while (continueFlag == "y");

            FileIO.UpdateFile(libraryName, books);
        }



    }
}