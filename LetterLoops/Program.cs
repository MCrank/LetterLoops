using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string");
            var userInput = Console.ReadLine();
            var outString = "";

            foreach (char userChar in userInput)
            {
                var userCharIndex = userInput.IndexOf(userChar) + 1;

                for (int i = 0; i < userCharIndex; i++)
                {
                    if (i == 0)
                    {
                        outString += userChar.ToString().ToUpper();
                    }
                    else
                    {
                        outString += userChar.ToString().ToLower();
                    }
                };
                if (userInput.IndexOf(userChar) != userInput.Length - 1)
                {
                    outString += "-";
                }
            }
            Console.WriteLine(outString);
            Console.ReadLine();
        }
    }
}
