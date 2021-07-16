using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MidtermProject
{
    public class UserInput
    {
        public string GetUserInput(string message)
        {
            string input;
            do
            {
                // print message
                Console.WriteLine(message);
                // get input
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input");
                }
                // if invalid go back to top
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
        
    }
}
