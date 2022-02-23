using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class WordToChar
    {

        public static List<char> ConvertStringToChar()
        {
            string word = DrawWord.wordToGuess().CapitalCity.ToUpper();
            List<char> characters = new List<char>();
            characters.AddRange(word);
            return characters;
        }
    }
}
