using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Book();
            var books = library.DisplayLibrary();
            foreach (var book in books)
            {
                Console.WriteLine($"We have {book.Title} by {book.Author}");
                if (book.InLibrary == true)
                {
                    Console.WriteLine("This book is available right now and available to be checked out");
                }
                else
                {
                    Console.WriteLine($"This book is currently checked out and will be available {book.DueDate}");
                }
            }

            Console.WriteLine("This is the work I've been doing");


            //Book.UpdateFile(fileName, listOfBooks);

            ////Read
            //Book.ReadFromFile(fileName);

            ////Delete
            //Book.DeleteFile(fileName);

        }
    }
}
