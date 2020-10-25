using System;
using System.Collections.Generic;
using System.Text;

namespace Subprograms
{
    public class QuestionsForUser
    {
        public bool GetInput(string userInput)
        {
            
            Console.WriteLine("Enter yes or no:\n");
            userInput = Console.ReadLine().ToUpper();
            if (userInput == "YES" || userInput == "NO")
            {
                return true;
            }

            return false;
        }
    }
}
