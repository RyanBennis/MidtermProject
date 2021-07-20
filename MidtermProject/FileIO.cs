using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MidtermProject
{
    class FileIO
    {
        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }


        }
        public static string UpdateFile(string fileName, List<Book> linesOfInput)
        {
            using StreamWriter streamWriter = new StreamWriter(fileName, false);

           // var library = new Book();
            //var linesOfInput = library.DisplayLibrary();
            foreach (var book in linesOfInput)
            {
                streamWriter.WriteLine($"{book.Title}, {book.Author}, {book.InLibrary}, {book.DueDate}");

            }

           // streamWriter.WriteLine("test");


            return "test";
        }
        public static List<Book> ReadFromFile(string fileName)
        {
            string line;
            List<Book> libraryFromFile = new List<Book>();
            using StreamReader streamReader = new StreamReader(fileName);
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] info = line.Split(", ");
                libraryFromFile.Add(new Book(
                    info[0],
                    info[1],
                    Enum.Parse<BookStatus>(info[2]),
                    DateTime.Parse(info[3])));
            }
            return libraryFromFile;
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }
    }
}
