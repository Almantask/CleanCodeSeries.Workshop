using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    public class CarFactory
    {
        public Car Create()
        {
            return new Car(100, 50, "F", 5, new Vector3D(0, 0, 0));
        }


    }
}
