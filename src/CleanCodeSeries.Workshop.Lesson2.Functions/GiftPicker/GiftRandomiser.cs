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
            int[] sizePool = new int[0];
            string[] colorPool = new string[0];
            if (gender == "male")
            {
                if (age < 2)
                {
                    sizePool = new []{1, 2, 3};
                    colorPool = new []{"white", "green", "black"};
                }
                else if (age < 12)
                {
                    if (age < 2)
                    {
                        sizePool = new[] { 3, 4, 5, 6 };
                        colorPool = new[] { "black", "white", "orange" };
                    }
                }

            }
            else if (gender == "female")
            {
                if (age < 2)
                {
                    sizePool = new[] { 1, 2, 3 };
                    colorPool = new[] { "purple", "pink" };
                }
                else if (age < 12)
                {
                    sizePool = new[] { 3, 4, 5, 6 };
                    colorPool = new[] { "purple", "red", "gold" };
                }
            }
            else
            {
                return null;
            }

            var i1 = _randomiser.Next(0, sizePool.Length - 1);
            var size = sizePool[i1];
            var i2 = _randomiser.Next(0, colorPool.Length - 1);
            var color = colorPool[i2];
            
            var gift = new Gift(color, size);

            return gift;
        }
    }
}
