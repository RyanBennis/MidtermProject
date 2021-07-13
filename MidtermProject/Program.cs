using System;
using System.Collections.Generic;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //C.R.U.D
            //Create Read Update and Delete
            //Create

            var fileName = "LibraryFile";
            Book.CreateFile(fileName);

            //update
            Dictionary<string, string> listOfBooks = new Dictionary<string, string>();

            listOfBooks.Add("Herman Melville", "Moby Dick");
            listOfBooks.Add("Bram Stoker", "Dracula");
            listOfBooks.Add("William Shakespeare", "Macbeth");
            listOfBooks.Add("Mary Shelley", "Frankenstein");
            listOfBooks.Add("Suzanne Collins", "Mockingjay");
            listOfBooks.Add("George Orwell", "1984");
            listOfBooks.Add("Stephenie Meyer", "Twilight");
            listOfBooks.Add("Stephen King", "Misery");
            listOfBooks.Add("Emma Donoghue", "Room");
            listOfBooks.Add("JRR Tolkien", "The Hobbit");
            listOfBooks.Add("James Joyce", "Ulysses");
            listOfBooks.Add("SE Hinton", "The Outsiders");



            Book.UpdateFile(fileName, listOfBooks);

            //Read
            Book.ReadFromFile(fileName);

            //Delete
            Book.DeleteFile(fileName);

        }
    }
}
