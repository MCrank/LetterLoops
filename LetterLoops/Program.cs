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

            for (int i = 0; i < userInput.Length; i++)
            {
                var userChar = userInput[i];
                var userCharIndex = i + 1;

                for (int s = 0; s < userCharIndex; s++)
                {
                    if (s == 0)
                    {
                        outString += userChar.ToString().ToUpper();
                    }
                    else
                    {
                        outString += userChar.ToString().ToLower();
                    }
                };
                if (i != userInput.Length - 1)
                {
                    outString += "-";
                }
            }
            Console.WriteLine(outString);
            Console.ReadLine();
        }
    }
}
