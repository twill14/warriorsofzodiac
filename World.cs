using System;
using System.Threading;
namespace WarriorsOfTheZodiac
{
    public class World
    {
        public World()
        {
        }


        public void WorldStart()
        {
            Console.WriteLine("You awaken to a tickling feeling as tiny water drops fall from the roof of the cave above and land gently on your face.\n");
            Thread.Sleep(2000);
            Console.WriteLine("Slowly, you arise from a soft mat that laid beneath you and stretch out your arms with a tremendous yawn.\n");
            Thread.Sleep(2000);
            Console.WriteLine("Despite still feeling foggy, your mind begins to take in the details of you room...\n");
            Thread.Sleep(1000);
            Console.WriteLine("And it is suddenly at this moment, when you realize that something is amiss.\n");
            Thread.Sleep(2000);
            Console.WriteLine("You have no idea where the hell you are, or how you even got here!\n");


        }
    }
}
