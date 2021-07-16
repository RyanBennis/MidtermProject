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
            FileIO.CreateFile(libraryName);





            var library = new Book();
            var books = library.DisplayLibrary();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");

            }

         var libraryContents = FileIO.UpdateFile(libraryName, books);



            //   Book.UpdateFile(fileName, listOfBooks);
            //   FileIO.UpdateFile(libraryName, myList);

            ////Read
            //Book.ReadFromFile(fileName);

            //Delete
          //  FileIO.DeleteFile(libraryName);


        }


    
    }
}
