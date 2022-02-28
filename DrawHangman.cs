using System;


namespace Hangman
{
    internal class DrawHangman
    {

        public void Draw(int chancesLeft)
        {
            switch(chancesLeft) {
                case 0:
                    Console.WriteLine("\n" +
                    "  ____   \n" +
                    " |    |  \n" +
                    " |       \n" +
                    " |       \n" +
                    " |       \n" +
                    "_|___    \n");
                    break;
                case 1:
                    Console.WriteLine("\n" +
                    "  ____   \n" +
                    " |    |  \n" +
                    " |    O  \n" +
                    " |       \n" +
                    " |       \n" +
                    "_|___    \n");                    
                    break;
                case 2:
                    Console.WriteLine("\n" +
                    "  ____  \n " +
                    " |    | \n " +
                    " |   _O_\n " +
                    " |      \n " +
                    "_|___   \n ");
                    break;
                case 3:
                    Console.WriteLine("\n" +
                    "  ____  \n " +
                    " |    | \n " +
                    " |   _O_\n " +
                    " |    | \n " +
                    "_|___   \n ");
                    break;
                case 4:
                    Console.WriteLine("\n" +
                    "  ____  \n " +
                    " |    | \n " +
                    " |   _O_\n " +
                    " |    | \n " +
                    "_|___/ \\n " +
                    "THE GAME IS OVER!");
                    break;
                case -1:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
            }

        }
        

  
    }
}
