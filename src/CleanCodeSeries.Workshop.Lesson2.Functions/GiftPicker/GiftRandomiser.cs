using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.GiftPicker
{
    public class GiftRandomiser
    {
        private const int ToddlerAgeLimit = 2;
        private const int KidAgeLimit = 12;

        private Random _randomiser;
        private IEnumerable<float> _sizePool;
        private IEnumerable<string> _colorPool;

        public GiftRandomiser()
        {
            _randomiser = new Random();
        }

        public Gift PickGift(Person person, IEnumerable<Gift> giftsPool)
        {
            _sizePool = PickSizePool(person.Age);
            _colorPool = PickColorPool(person.Age, person.Gender);
            var gift = PickARandomGift(giftsPool);

            return gift;
        }

        private IEnumerable<float> PickSizePool(int age)
        {
            IEnumerable<float> sizePool = null;

            if (age < ToddlerAgeLimit)
            {
                sizePool = new[] { 1.0f, 2.0f, 3.0f };
            }
            else if (age < KidAgeLimit)
            {
                sizePool = new[] { 3.0f, 4.0f, 5.0f, 6.0f };
            }

            return sizePool;
        }

        private IEnumerable<string> PickColorPool(int age, Gender gender)
        {
            IEnumerable<string> colorPool = null;

            if (gender == Gender.Male)
            {
                if (age < ToddlerAgeLimit)
                {
                    colorPool = new[] { "white", "green", "black" };
                }
                else if (age < KidAgeLimit)
                {
                    colorPool = new[] { "black", "white", "orange" };
                }

            }
            else if (gender == Gender.Female)
            {
                if (age < ToddlerAgeLimit)
                {
                    colorPool = new[] { "purple", "pink" };
                }
                else if (age < KidAgeLimit)
                {
                    colorPool = new[] { "purple", "red", "gold" };
                }
            }

            return colorPool;
        }

        private Gift PickARandomGift(IEnumerable<Gift> giftsPool)
        {
            var giftsFiltered = FilterGifts(giftsPool);
            var gift = PickRandom(giftsFiltered);

            return gift;
        }

        private IEnumerable<Gift> FilterGifts(IEnumerable<Gift> giftsPool)
        {
            var giftsFiltered = giftsPool
                .Where(g => _sizePool.Contains(g.Size))
                .Where(g => _colorPool.Contains(g.Color));

            return giftsFiltered;
        }

        private Gift PickRandom(IEnumerable<Gift> gifts)
        {
            var index = _randomiser.Next(gifts.Count());
            var gift = gifts.ToList()[index];

            return gift;
        }
    }
}
