using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class CarCache
    {
        private List<Car> _cars;

        public CarCache()
        {
            _cars = new List<Car>();
        }

        public void Insert(Car car, int at)
        {
            _cars.Insert(at, car);
        }

        public Car Get(int i)
        {
            return _cars[i];
        }

        public Car Get(Car car)
        {
            return car;
        }

        public void Remove(Car car)
        {
            _cars.Remove(car);
        }

        public void Remove(int i)
        {
            _cars.RemoveAt(i);
        }

    }
}
