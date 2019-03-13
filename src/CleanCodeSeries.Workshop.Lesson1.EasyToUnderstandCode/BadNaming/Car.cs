using System;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    public class Car
    {
        public float Speed { get; }
        public float FuelTankCapacity { get; }
        public string FuelType{ get; }
        public float LitresPerKm { get; }
        public Vector3D Position { get; }

        public Car(float speed, float fuelTankCapacity, string fuelType, 
            float litresPerKm, Vector3D position)
        {
            Speed = speed;
            FuelTankCapacity = fuelTankCapacity;
            FuelType = fuelType;
            LitresPerKm = litresPerKm;
            Position = position;
        }
                
        public void Drive(Vector3D to)
        {
            Console.WriteLine($"Driving {to}");
        }

    }
}
