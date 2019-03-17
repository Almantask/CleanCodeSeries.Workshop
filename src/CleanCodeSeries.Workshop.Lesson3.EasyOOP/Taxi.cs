using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    public class Taxi:Car
    {
        private bool _isTaken;
        public bool IsTaken => _isTaken;

        public void DeliverCustomer(TaxiCustomer customer, Vector3 to)
        {
            _isTaken = true;
            // fee = distance / euroPerKilo
            // kick 
            Drive(to);  

        }

        public Taxi(float s, float fuel, string type, float lKM, Vector3 position) : base(s, fuel, type, lKM, position)
        {
        }
    }
}
