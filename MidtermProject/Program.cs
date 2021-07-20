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
            var library = new Book();
            var books = library.DisplayLibrary();
            //FileIO.CreateFile(libraryName);
            do
            {

                Console.WriteLine("Here are the books that we have in our Library");
                
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }
                var userInput = new UserInput();
                string searchAuthor = userInput.GetUserInput("Please enter the name of a book or an Author?");

                var searchMethod = new SearchMethod();
                var searchedBooks = searchMethod.Titles(books, searchAuthor);

                var returnBook = new ReturnBook();
                var returnbooks = returnBook.Return(books, searchAuthor);

                var userInput1 = new UserInput();
                continueFlag = userInput1.GetUserInput("Do you want to continue (y/n)");
                  FileIO.UpdateFile(libraryName, books);
            } while (continueFlag == "y");


            //Console.WriteLine("This is the work I've been doing");
            //var test = new List<Book>(library.DisplayLibrary());
            //var libraryContents = FileIO.UpdateFile(libraryName, test);

         
            ////Read
            //Book.ReadFromFile(fileName);
            //Delete

            //  Book.DeleteFile(libraryName);
        }



    }
}