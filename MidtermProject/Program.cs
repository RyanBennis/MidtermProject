using System;
using System.Collections.Generic;
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

            Console.WriteLine("This is the work I've been doing");

            var test = new List<Book>(library.DisplayLibrary());

           var libraryContents = Book.UpdateFile(libraryName, test);



            // Book.UpdateFile(fileName, listOfBooks);

            ////Read
            //Book.ReadFromFile(fileName);

            //Delete
          //  Book.DeleteFile(libraryName);

        }
    }
}
