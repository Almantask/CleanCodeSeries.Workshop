using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class CarCache
    {
        private List<Car> _cars;

        public CarCache()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car, int at)
        {
            _cars.Insert(at, car);
        }

        public Car RetrieveCar(int i)
        {
            return _cars[i];
        }

        public Car SetCar(Car car)
        {
            return car;
        }

        public void DestroyCar(Car car)
        {
            _cars.Remove(car);
        }

        public void DestroyCar(int i)
        {
            _cars.RemoveAt(i);
        }

    }
}
