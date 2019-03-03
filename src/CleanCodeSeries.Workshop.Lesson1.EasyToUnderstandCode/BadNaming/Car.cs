using System;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    public class Car
    {
        //Speed
        public float S { get; }
        // Fuel tank capacity
        public float FuelFloat { get; }
        // Type of fuel
        public string FuelString{ get; }
        // Litres per km
        public float LKM { get; }
        private Vector3 _position;

        public Car(float s, float fuel, string type, float lKM, Vector3 position)
        {
            S = s;
            FuelFloat = fuel;
            FuelString = type;
            LKM = lKM;
            _position = position;
        }

        public Vector3 Position => _position;

        public void Drive(Vector3 to)
        {
            Console.WriteLine($"Driving {to}");
        }

    }
}
