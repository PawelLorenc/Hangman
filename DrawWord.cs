using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class DrawWord
    {
        public static Capital CapitalToGuess()
        {
            LoadWords loadWords = new LoadWords();
            List<Capital> capitals = loadWords.LoadCapitalsFromFile();
            Random random = new Random();           
            return capitals.ElementAt(random.Next(0, capitals.Count));
        }
        

    }
}
