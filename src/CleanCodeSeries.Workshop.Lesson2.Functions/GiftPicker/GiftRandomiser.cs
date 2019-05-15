using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.Big
{
    public static class GiftRandomiser
    {
        private static Random _randomiser;

        // There are multiple criterias based ona which a gif will need to be picked.
        public static Gift PickGift(string name, string gender, int age, string eyeColor, IEnumerable<Gift> giftsPool)
        {
            float[] sizePool = new float[0];
            string[] colorPool = new string[0];
            if (gender == "male")
            {
                if (age < 2)
                {
                    sizePool = new []{ 1.0f, 2.0f, 3.0f };
                    colorPool = new []{"white", "green", "black"};
                }
                else if (age < 12)
                {
                    if (age < 2)
                    {
                        sizePool = new[] { 3.0f, 4.0f, 5.0f, 6.0f };
                        colorPool = new[] { "black", "white", "orange" };
                    }
                }

            }
            else if (gender == "female")
            {
                if (age < 2)
                {
                    sizePool = new[] { 1.0f, 2.0f, 3.0f };
                    colorPool = new[] { "purple", "pink" };
                }
                else if (age < 12)
                {
                    sizePool = new [] { 3.0f, 4.0f, 5.0f, 6.0f };
                    colorPool = new[] { "purple", "red", "gold" };
                }
            }
            else
            {
                return null;
            }

            var giftsFiltered = giftsPool
                .Where(g => sizePool.Contains(g.Size))
                .Where(g => colorPool.Contains(g.Color))
                .OrderBy(g => new Guid())
                .ToList();

            return giftsFiltered[0];
        }
    }
}
