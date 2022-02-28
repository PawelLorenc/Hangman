using System;

namespace Hangman
{
    internal class LoadWords
    {

        public List<Capital> LoadCapitalsFromFile()
        {
            List<Capital> listOfCapitals = new List<Capital>();

            string filePath = Resource.countries_and_capitals;

            List<string> stringList = filePath.Split("\r\n").ToList();

            foreach (var line in stringList)
            {
                Capital capitals = new Capital();
                string[] splittedWords = line.Split(" | ");

                capitals.CapitalCity = splittedWords[0];
                capitals.Country = splittedWords[1];

                listOfCapitals.Add(capitals);
            }
            return listOfCapitals;      
        }
    }
}
