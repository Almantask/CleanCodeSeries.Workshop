using CleanCodeSeries.Workshop.Lesson2.Functions.Big;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.GiftPicker
{
    public class GiftRandomiser
    {
        private Random _randomiser;
        private float[] _sizePool = new float[0];
        private string[] _colorPool = new string[0];
        IEnumerable<Gift> giftsPool;

        const int maxToddlerAge = 2;
        const int minTennageAge = 12;

        public GiftRandomiser(IEnumerable<Gift> giftsPool)
        {
            _randomiser = new Random();
        }

        public Gift PickGift(Person  receiver)
        {
            try
            {
                SetPool(receiver.Gender, receiver.Age);
            }
            catch
            {
                return null;
            }

            List<Gift> giftsFiltered = FilterGiftsByPools();
            return PickRnadomGift(giftsFiltered);
        }

        private void SetPool(Gender gender, int age)
        {
            SetGiftSizePool(age);
            SetGiftColorPool(age, gender);
        }

        private List<Gift> FilterGiftsByPools()
        {
            return giftsPool
                            .Where(g => _sizePool.Contains(g.Size))
                            .Where(g => _colorPool.Contains(g.Color)).ToList();
        }

        private Gift PickRnadomGift(List<Gift> giftsFiltered)
        {
            if (giftsFiltered.Any() == false) return null;

            var index = _randomiser.Next(giftsPool.Count() - 1);

            return giftsFiltered[index];
        }

        void SetGiftSizePool(int age)
        {
            var toddlerGiftSizePool = new[] { 1.0f, 2.0f, 3.0f }; ;
            var teenagerGiftSizePool = new[] { 3.0f, 4.0f, 5.0f, 6.0f };

            if (age < maxToddlerAge)
            {
                _sizePool = toddlerGiftSizePool;
            }
            else if (age < minTennageAge)
            {
                _sizePool = teenagerGiftSizePool;
            }
            else
            {
                throw new Exception("Too old for a gift");
            }
        }

        private void SetGiftColorPool(int age, Gender gender)
        {
            var giftColorPoolsPerGender = new Dictionary<Gender, Action<int>>
            {
                { Gender.Male, SetMaleGiftColorPool },
                { Gender.Female, SetFemaleGiftColorPool }
            };

            try
            {
                var giftPoolSetter = giftColorPoolsPerGender[gender];
                giftPoolSetter(age);
            }
            catch
            {
                throw new Exception("No gifts for other genders.");
            }
        }

        private void SetFemaleGiftColorPool(int age)
        {
            if (age < maxToddlerAge)
            {
                _colorPool = new[] { "purple", "pink" };
            }
            else if (age < minTennageAge)
            {
                _colorPool = new[] { "purple", "red", "gold" };
            }
        }

        private void SetMaleGiftColorPool(int age)
        {
            if (age < maxToddlerAge)
            {
                _colorPool = new[] { "white", "green", "black" };
            }
            else if (age < minTennageAge)
            {
                _colorPool = new[] { "black", "white", "orange" };
            }
        }
    }
}
