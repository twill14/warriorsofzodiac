using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Input;

namespace WarriorsOfTheZodiac
{
    public class World
    {
        public World()
        {
        }

        public static class Keyboard{
            
        }

        public void WorldStart()
        {
            int textCounter = 0;

            List<string> startingText = new List<string>();

            startingText.Add("You awaken to a tickling feeling as tiny water drops fall from the roof of the cave above and land gently on your face.\n");
            startingText.Add("Slowly, you arise from a soft mat that laid beneath you and stretch out your arms with a tremendous yawn.\n");
            startingText.Add("Despite still feeling foggy, your mind begins to take in the details of you room...\n");
            startingText.Add("And it is suddenly at this moment, when you realize that something is amiss.\n");
            startingText.Add("You have no idea where the hell you are, or how you even got here!\n");

            do
            {
                if(Keyboard.){

                }
                Thread.Sleep(2000);
                Console.WriteLine(startingText[textCounter]);
                
            } while (textCounter != startingText.Count);
        }
    }
}
