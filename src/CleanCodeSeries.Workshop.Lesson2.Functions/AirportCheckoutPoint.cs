using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions
{
    class AirportCheckoutPoint
    {
        public void Checkout(string name, string surename,
            string bookingNumber, DateTime date,
            string id, string airline)
        {

        }
    }
}

namespace CleanCodeSeries.Workshop.Lesson2.Functions.Clean
{
    class AirportCheckoutPoint
    {
        public void Checkout(Person person, Ticket ticket)
        {

        }
    }

    internal class Ticket
    {
        public string BookingNumber { get; }
        public DateTime date { set; get; }
        public string Airline { get; }

        public Ticket(string bookingNumber, DateTime date, string airline)
        {
            BookingNumber = bookingNumber;
            this.date = date;
            Airline = airline;
        }
    }

    class Person
    {
        public string Name { set; get; }
        public string Surename { set; get; }
        public string Id { get; }

        public Person(string name, string surename, string id)
        {
            Name = name;
            Surename = surename;
            Id = id;
        }
    }
}
