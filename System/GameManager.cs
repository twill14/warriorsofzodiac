using System;
namespace WarriorsOfTheZodiac
{
    public class GameManager
    {
        // Manages the game's basic systems

        public GameManager()
        {
        }

        public void GameBegin()
        {
            string intro = "Welcome to Warriors of the Zodiac\n";
            //Console.SetCursorPosition((Console.WindowWidth - intro.Length) / 2, Console.CursorTop);
            Console.WriteLine(intro);
        }



        public void displayMainMenu()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit Game");
            Console.WriteLine("3. About\n");
        }


        public void StartGame()
        { 

        }

        public void ExitGame() 
        { }

        public void AboutGame()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("WOTZ is a game I made to practice C# and make something fun at the same time.");
            Console.WriteLine("-----------------------------------------------------------------------------\n");

        }

        public void ToggleMenu() 
        { }

       


    }
}
