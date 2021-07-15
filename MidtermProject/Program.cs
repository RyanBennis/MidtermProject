using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Screen, under construction 
            // Console.WriteLine("Welcome to our Library What would you like to do?");
            // Console.WriteLine("");

            var libraryName = "CurrentBookList.txt";
            Book.CreateFile(libraryName);





            var library = new Book();
            var books = library.DisplayLibrary();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");

            }

            var test = new List<Book>(library.DisplayLibrary());

           var libraryContents = Book.UpdateFile(libraryName, test);

            string continueFlag;
            Console.WriteLine("Welcome to our Library, We are happy you are here");

            do
            {
                Console.WriteLine("Here are the books that we have in our Library");
                var library = new Book();
                var books = library.DisplayLibrary();
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                    //if (book.InLibrary == true)
                    //{
                    //    Console.WriteLine("This book is available right now and available to be checked out");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"This book is currently checked out and will be available {book.DueDate}");
                    //}
                }
                Titles(books);
                continueFlag = GetUserInput("Do you want to continue (y/n)");
            } while (continueFlag == "y");
        }

            static string GetUserInput(string message)
            {
                string input;
                do
                {
                    // print message
                    Console.WriteLine(message);
                    // get input
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Invalid input");
                    }
                    // if invalid go back to top
                } while (string.IsNullOrWhiteSpace(input));
                return input;
            }
        
       

           //public static void List(List<Book> books)
           // {
           //     //var results1 = moviess;
           //     foreach (var book in books)
           //     {
           //         Console.WriteLine($"{book.Title}");
           //     }
           // }
            public static void Titles(List<Book> books)
            {
                //Console.WriteLine("What category are you interested in?");
                //string input = Console.ReadLine();
                foreach (var bookList in books)
                {
                    Console.WriteLine($"{bookList.Title}:{bookList.Author}");
                }

                string input = GetUserInput("What category are you interested in?");
                var results = books.Where(book => book.Author == input);

                foreach (var book in results)
                {
                    Console.WriteLine($"{book.Title}: {book.InLibrary}: {book.DueDate}");
                }

            }
            //Book.UpdateFile(fileName, listOfBooks);
            // Book.UpdateFile(fileName, listOfBooks);

            ////Read
            //Book.ReadFromFile(fileName);

            //Delete
          //  Book.DeleteFile(libraryName);

        
    }
}
