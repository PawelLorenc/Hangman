using System;


namespace Hangman
{
    internal class GameLogic
    {
        Capital capital;
        private CoverAndUncoverLetters coverAndUncoverLetters;
        private DrawHangman hangman = new();
        private int chancesLeft;
        public void startTheGame()
        {
            capital = DrawWord.CapitalToGuess();
            coverAndUncoverLetters = new CoverAndUncoverLetters(capital.CapitalCity.ToUpper());
            for (chancesLeft = 0; chancesLeft < 5; chancesLeft++)
            {
                printChancesAndUsedLetters(chancesLeft);
                wordOrLetterMessage();
                hangman.Draw(chancesLeft);
            }
        }

        private void printChancesAndUsedLetters(int chancesLeft)
        {
            int chancesTotal = 5;
            Console.WriteLine("You have " + (chancesTotal - chancesLeft) + " chances left");
            if (chancesLeft != 0)
            {
                Console.WriteLine("Guessed letters: " + String.Join(", ", coverAndUncoverLetters.returnGuessedChar()));
            }

        }



        private void guessLetter()
        {

            bool outcome = coverAndUncoverLetters.Guess(CheckChar());
            printCoveredWord();
           if(outcome)
            {
                chancesLeft--;
            }
        }

        private void printCoveredWord()
        {
            List<char> list = coverAndUncoverLetters.LettersToUncover();
            for (int y = 0; y < list.Count; y++)
            {
                Console.Write(list[y]);
            }
            Console.WriteLine();
        }

        private char CheckChar()
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
                if ((lenght != 1 || (asc < 'A' || asc > 'Z')) && (asc != ' '))
                    {
                    Console.WriteLine("Provided character isn't correct");
                    }  
            } while ((lenght != 1 || (asc < 'A' || asc > 'Z')) && (asc != ' '));
            return ch;
        }

        private void guessWord()
        {
            string word = Console.ReadLine();
            if (coverAndUncoverLetters.GuessWholeWord(word))
            {
                Console.WriteLine("Congrats! You won!");
                chancesLeft--;
            }
            else
            {
                Console.WriteLine("Incorrect.");
                chancesLeft++;
            }
        }


        private void printHangman(int chanses)
        {
            hangman.Draw(chanses);
        }

        private void wordOrLetterMessage()
        {
            Console.WriteLine("Would you like to guess the whole word or a letter? Type word for word and letter for letter");
            bool flag = true;
            while (flag)
            {
                string userInput = Console.ReadLine().ToUpper();
                if (userInput.Equals("LETTER"))
                {
                    guessLetter();
                    flag = false;
                }
                else if (userInput.Equals("WORD"))
                {
                    guessWord();
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Type word or letter");
                }
            }

        }
    }
}
