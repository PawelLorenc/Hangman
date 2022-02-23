using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class CoverAndUncoverLetters
    {

        public static List<char> guessedChars = new List<char>();
        public static List<char> charToGuess = new List<char>(WordToChar.ConvertStringToChar());
        public static List<char> charToUncover = new List<char>();
        private static bool flag = true;



        public static List<char> LettersToUncover()
        {
            if (flag)
            {
                CoverLetters();
                flag = false;
            }

            guessedChars.Add(CheckChar());
            for (int i = 0; i < charToGuess.Count; i++)
            {
                for (int y = 0; y < guessedChars.Count; y++)
                {
                    if (charToGuess[i].Equals(guessedChars[y]))
                    {
                        charToUncover[i] = guessedChars[y];
                    }
                }
            }
            return charToUncover;
        }

        


        private static char CheckChar()
        {
            int lenght;
            int asc;
            char ch;
            do
            {
                string charToCheck = Console.ReadLine().ToUpper();
                lenght = charToCheck.Length;
                ch = charToCheck[0];
                asc = (int)charToCheck[0];
                if (lenght != 1 || (asc < 65 || asc > 90))
                {
                    Console.WriteLine("Provided character isn't correct");
                }
            } while (lenght != 1 || (asc < 65 || asc > 90));
            return ch;
        }

        private static void CoverLetters()
        {
             foreach (char ch in charToGuess)
            {
                charToUncover.Add('_');
            }
        }
    }
}