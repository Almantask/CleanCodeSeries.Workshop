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

            var brains1 = new Brains();

            var zombie2 = new Zombie();

            var brains2 = new Brains();

            var bainss = new[] { brains1, brains2 };

            var zombies = new[] { zombie1, zombie2 };

            mess.Execute();

            for (int index = 0; index < 2; index++)
            {
                zombies[index].Seek(bainss[index]);
            }
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