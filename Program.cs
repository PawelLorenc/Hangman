
using Hangman;

List<char> list = new List<char>();

for (int i = 0; i < 30; i++)
{
    list = CoverAndUncoverLetters.LettersToUncover();
    for (int y = 0; y < list.Count; y++)
    {
        Console.Write(list[y]);
    }
    Console.WriteLine();
}