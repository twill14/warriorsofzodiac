using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Input;

namespace WarriorsOfTheZodiac
{
    public class World
    {

        public static int textCounter;

        public void DisplayWeaponChoices()
        {
            Console.WriteLine("1. Sword");
            Console.WriteLine("2. Staff");
            Console.WriteLine("3. Bow\n");
        }

        public void ResetTextCounter()
        {
            textCounter = 0;
        }

        public void WorldStart()
        {
            var main = new Program();
            
            int weaponSelection = 0;

            List<string> startingText = new List<string>();

            List<string> chapterOne = new List<string>();

            Console.WriteLine("\n\nYou awaken to a tickling feeling as tiny water drops fall from the roof of the cave above and lands gently on your face.\n");
            Thread.Sleep(2000);
            Console.WriteLine("[Press Z key to continue.]\n");

            startingText.Add("Slowly, you arise from a soft mat that laid beneath you and stretch out your arms with a tremendous yawn.\n");
            startingText.Add("Despite still feeling foggy, your mind begins to take in the details of you room...\n");
            startingText.Add("And it is suddenly at this moment, when you realize that something is amiss.\n");
            startingText.Add("You have no idea where the hell you are, or how you even got here!\n");

            do
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Z)
                {
                    Thread.Sleep(400);
                    Console.WriteLine(startingText[textCounter]);
                    textCounter += 1;
                }

                
            } while (textCounter != startingText.Count);

            ResetTextCounter();
            Console.Clear();

            chapterOne.Add("You decide to venture out of the cave.\n");
            chapterOne.Add("Step by step, all you hear is the drippiness of the dark cave.\n");
            chapterOne.Add("But suddenly, you hear a 'squish' \n");
            chapterOne.Add("And when you turn around, you come face to boot with a slime!\n");
            chapterOne.Add("At first you laugh at the slime and it's puny, squishly looking body.\n");
            chapterOne.Add("But then you notice, that just behind the slime are countless remains of it's previous victims!\n");
            chapterOne.Add("You bolt in terror as the slime chases you!\n");
            chapterOne.Add("Not before long you're backed into a corner. Oh what to do!\n");
            chapterOne.Add("But just as you were about to give in to surrender to the squishy, you notice in the corner of your eye...\n");
            chapterOne.Add("A weapon!\n");
            chapterOne.Add("With blinding speed you run past the slime and pick up a...\n");

            do
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Z)
                {
                    Thread.Sleep(400);
                    Console.WriteLine(chapterOne[textCounter]);
                    textCounter += 1;
                }


            } while (textCounter != chapterOne.Count);

            Console.WriteLine("Which weapon do you choose?\n");
            DisplayWeaponChoices();

            do
            {
                var keyPress = Console.ReadKey(true);

                switch (keyPress.Key)
                {
                    case ConsoleKey.D1:
                        weaponSelection = 1;
                        Console.WriteLine("You grab the sword and prepare for combat!\n");
                        break;
                    case ConsoleKey.D2:
                        weaponSelection = 2;
                        Console.WriteLine("You grab the staff and prepare for combat!\n");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("You grab the bow and prepare for combat!\n");
                        weaponSelection = 3;
                        break;
                }
            } while (weaponSelection == 0);
        }
    }
}
