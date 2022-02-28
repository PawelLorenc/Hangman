using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class CoverAndUncoverLetters
    {
        List<char> charToGuess;
        List<char> charToUncover = new List<char>();
        List<char> guessedChars = new List<char>();

        public CoverAndUncoverLetters(string wordToGuess)
        {
            charToGuess = wordToGuess.ToCharArray().ToList();
            CoverLetters();
        }

        private void CoverLetters()
        {
            foreach (char ch in charToGuess)
            {
                charToUncover.Add('_');
            }
        }

        public List<char>  returnGuessedChar()
        {
            
                return guessedChars;
            
        }

        public bool Guess(char letter)
        {
            bool isCorrect = false;
            guessedChars.Add(letter);
            for (int i = 0; i < charToGuess.Count; i++)
            {
                if (letter.Equals(charToGuess[i]))
                {
                    charToUncover[i] = letter;
                    isCorrect = true;
                }
            }
            if (isCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<char> LettersToUncover()
        {
            return charToUncover;
        }

        public bool GuessWholeWord(string word)
        {
            char[] stringChar = word.ToCharArray();
            for (int i = 0; i < charToGuess.Count(); i++)
            {
                if (!stringChar[i].Equals(charToGuess[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}