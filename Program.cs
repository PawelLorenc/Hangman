
using Hangman;


foreach (LoadWords line in LoadWords.TXTfileToList())
{
    Console.WriteLine(line.Country);
}
