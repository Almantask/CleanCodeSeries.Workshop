using System.Collections.Generic;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    public class TaxiService
    {
        public IList<Taxi> Taxis;

        public TaxiService()
        {
            Taxis = new List<Taxi>()
            {
                new Taxi(160, 80, "Diesel", 1, new Vector3()),
                new Taxi(200, 100, "Petrol", 1.2f, new Vector3())
            };
        }
    }

    public class TaxiCustomer
    {
        private Vector3 _locationCurrent;
        public Vector3 LocationCurrent => _locationCurrent;

        public TaxiCustomer(Vector3 locationCurrent)
        {
            _locationCurrent = locationCurrent;
        }

        public void TravelViaTaxi(TaxiService service, Vector3 locationTo)
        {
            //var taxi = service.Taxis
            //taxi.DeliverCustomer(locationTo);
        }



    }
}
