using System;

namespace Hangman
{
    internal class LoadWords
    {
        public string CapitalCity { get; private set; }
        public string Country { get; private set; }

        public static List<LoadWords> TXTfileToList()
        {
            List<LoadWords> listOfWords = new List<LoadWords>();

            string filePath = Hangman.Resource.countries_and_capitals;

            List<string> stringList = new List<string>();

            stringList = filePath.Split("\r\n").ToList();

            foreach (var line in stringList)
            {
                LoadWords newWord = new LoadWords();
                string[] splittedWords = line.Split('|');

                newWord.CapitalCity = splittedWords[0];
                newWord.Country = splittedWords[1];

                listOfWords.Add(newWord);
            }
            return listOfWords;      
        }
    }
}
