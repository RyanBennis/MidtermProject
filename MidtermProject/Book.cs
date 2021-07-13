using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MidtermProject
{
   public class Book
    {


        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }


        }
        public static void UpdateFile(string fileName, Dictionary<string, string> linesOfInput = null)
        {
            using StreamWriter streamWriter = new StreamWriter(fileName, true);
            if (linesOfInput == null || !linesOfInput.Any())
            {
                streamWriter.WriteLine("This is the book class I am adding to");
            }
            else
            {
                foreach (var line in linesOfInput)
                {
                    streamWriter.WriteLine(line);
                }
            }
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
