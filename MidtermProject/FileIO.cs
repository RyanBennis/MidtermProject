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
                streamWriter.WriteLine($"{book.Title}, {book.Author}, {book.DueDate},{book.InLibrary}");

            }

           // streamWriter.WriteLine("test");


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
