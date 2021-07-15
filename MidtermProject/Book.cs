using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MidtermProject
{
    public class Book
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public bool InLibrary { get; set; }

        public DateTime DueDate { get; set; }

        public Book()
        {
        }
            

        public Book(string author, string title, bool inLibrary, DateTime dueDate )
        {
            Author = author;
            Title = title;
            InLibrary = inLibrary;
            DueDate = dueDate;
        }


        public List<Book> DisplayLibrary()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Herman Melville", "Moby Dick", true, DateTime.Today));
            bookList.Add(new Book("Bram Stoker", "Dracula", true, DateTime.Today));
            bookList.Add(new Book("William Shakespeare", "Macbeth", true, DateTime.Today));
            bookList.Add(new Book("Mary Shelley", "Frankenstein", true, DateTime.Today));
            bookList.Add(new Book("Suzanne Collins", "Mockingjay", true, DateTime.Today));
            bookList.Add(new Book("George Orwell", "1984", false, DateTime.Today));
            bookList.Add(new Book("Stephenie Meyer", "Twilight", false, DateTime.Today));
            bookList.Add(new Book("Stephen King", "Misery", true, DateTime.Today));
            bookList.Add(new Book("Emma Donoghue", "Room", true, DateTime.Today));
            bookList.Add(new Book("JRR Tolkien", "The Hobbit", true, DateTime.Today));
            bookList.Add(new Book("James Joyce", "Ulysses", false, DateTime.Today));
            bookList.Add(new Book("SE Hinton", "The Outsiders", false, DateTime.Today));

            return bookList;
        }
        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }


        }
        public static string UpdateFile(string fileName, List<Book> linesOfInput = null)
        {
            //using StreamWriter streamWriter = new StreamWriter(fileName, false);


            var library = new Book();
            var books = library.DisplayLibrary();
            //File.WriteAllText(fileName,$"{library.Title} by {library.Author}");

            foreach (var book in linesOfInput)
           {

                Console.WriteLine(($"{book.Title} by {book.Author}"));

            }


            return "test";
        }
        public static void ReadFromFile(string fileName)
        {
            using StreamReader streamReader = new StreamReader(fileName);

            //this is new way
            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }


    }
}
