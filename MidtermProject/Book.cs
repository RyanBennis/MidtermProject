using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermProject
{
    public class Book
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public BookStatus InLibrary { get; set; }

        public DateTime DueDate { get; set; }

        public Book()
        {
        }
            

        public Book(string author, string title, Enum inLibrary, DateTime dueDate )
        {
            Author = author;
            Title = title;
            DueDate = dueDate;
        }


        public List<Book> DisplayLibrary()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Herman Melville", "Moby Dick", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Bram Stoker", "Dracula", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("William Shakespeare", "Macbeth", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Mary Shelley", "Frankenstein", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Suzanne Collins", "Mockingjay", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("George Orwell", "1984", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Stephenie Meyer", "Twilight", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Stephen King", "Misery", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("Emma Donoghue", "Room", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("JRR Tolkien", "The Hobbit", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("James Joyce", "Ulysses", BookStatus.On_Shelf, DateTime.Today));
            bookList.Add(new Book("SE Hinton", "The Outsiders", BookStatus.On_Shelf, DateTime.Today));

            return bookList;
        }
    }
}