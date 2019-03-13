using System;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadCodeStructure
{
    class ChaoticSimulation
    {
        public void Simulate()
        {
            var mess = new Mess();
            
            var zombie1 = new Zombie();
            var zombie2 = new Zombie();
            var zombies = new[] { zombie1, zombie2 };

            var brains1 = new Head();
            var brains2 = new Head();
            var brains = new[] { brains1, brains2 };
            
            mess.Execute();

            // What is 2 for?
            for (int index = 0; index < 2; index++)
            {
                ZombieSeekForBrains(zombies[index], brains[index]);
            }
        }

        private void ZombieSeekForBrains(Zombie zombie, Head head)
        {
            zombie.Seek(head);
        }

        public void RunSimulation()
        {
            Simulate();
        }

        public void ReSimulate(int times)
        {
            for (int i = 0; i < times; i++)
            {

                Console.WriteLine($"{i} Simulation has started @{DateTime.Now}. It will create a mess, zombie will seek brains.");

                RunSimulation();

                Console.WriteLine($"{i} Simulation has been successfully run. Congratulations");

            }

        }
    }
}
