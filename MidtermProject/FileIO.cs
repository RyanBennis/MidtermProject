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
