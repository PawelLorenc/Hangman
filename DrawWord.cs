using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class DrawWord
    {

        private static int DrawNumber()
        {
            Random random = new Random();
            int randomNumberToDraw = random.Next(0, LoadWords.TXTfileToList().Count);
            return randomNumberToDraw;
        }

        public static LoadWords wordToGuess()
        {
           return LoadWords.TXTfileToList().ElementAt(DrawNumber());
        }       

    }
}
