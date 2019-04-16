using System;
using System.Threading;

namespace WarriorsOfTheZodiac
{
    class Program
    {
        public static bool gameStart;
        public static bool inGame;
        public static bool inMenu;

        static void Main(string[] args)
        {
           

            var newGame = new GameManager();
            var world = new World();
            

            newGame.GameBegin();
            newGame.displayMainMenu();
            int menuInput = 0;

            do
            {
                var keyPress = Console.ReadKey(true);

                switch (keyPress.Key)
                {
                    case ConsoleKey.D1:
                        menuInput = 1;
                        gameStart = true;
                        break;
                    case ConsoleKey.D2:
                        menuInput = 2;
                        break;
                    case ConsoleKey.D3:
                        menuInput = 3;
                        break;
                }

                switch (menuInput)
                {
                    case 1:
                        Console.WriteLine("The Story Begins...\n");
                        Thread.Sleep(3000);
                        Console.Clear();
                        
                        inGame = true;

                        if (gameStart)
                        {
                            world.WorldStart();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Thanks for playing!");
                        break;
                    case 3:
                        newGame.AboutGame();
                        break;
                    default:
                        break;
                }

            } while (menuInput != 2);

            if (menuInput == 2)
            {
                Environment.Exit(1);
            }

        }
    }
}
