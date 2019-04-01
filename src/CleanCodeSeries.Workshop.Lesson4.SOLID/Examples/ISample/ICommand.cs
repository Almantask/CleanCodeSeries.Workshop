using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples.ISample
{
    public interface ICommand
    {
        void Execute();
    }

    public struct InvoiceDetails
    {
        public readonly string Item;
        public readonly int Quantity;
        public InvoiceDetails(string item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }

    public class SimpleInvoice
    {
        private IList<InvoiceDetails> _details;
        public SimpleInvoice()
        {
            _details = new List<InvoiceDetails>();
        }
        public void AddDetail(InvoiceDetails detail)
        {
            _details.Add(detail);
        }
        public InvoiceDetails GetDetail(int index)
        {
            return _details[index];
        }
    }

    public class InvoiceWithHeader
    {
        public InvoiceHeader Header { get; }
        private SimpleInvoice _details;

        public InvoiceWithHeader(InvoiceHeader header)
        {
            _details = new SimpleInvoice();
        }

        public void AddDetail(InvoiceDetails detail)
        {
            _details.AddDetail(detail);
        }
        public InvoiceDetails GetDetail(int index)
        {
            return _details.GetDetail(index);
        }
    }

    public struct InvoiceHeader
    {
        public readonly string ContactId;
        public readonly DateTime SignedAt;
        public readonly int Cost;
    }

    public class InvoiceSummary
    {
    }


    public interface IInvoice
    {
        void AddDetail(InvoiceDetails details);
        InvoiceDetails GetDetail(int index);
    }

    public class Vehicle
    {
        private readonly Body _body;
        private readonly Engine _engine;
        private Location _current;
        public Vehicle(Body body, Engine engine)
        {
            _body = body;
            _engine = engine;
        }

        public virtual void Move(Location to)
        {
            _current = to;
        }
    }

    public class BrokenVechile : Vehicle
    {
        public BrokenVechile(Body body, Engine engine) : base(body, engine)
        {
        }

        public override void Move(Location to)
        {
            throw new Exception("Too broken to move.");
        }


    }

    public class Location
    {
    }

    public class Body
    {

    }

    public class Engine
    {

    }

    interface IPayable
    {
        void Pay(decimal amount);
    }

    // Change requested
    interface IInvoicable
    {
        void SendInvoice(string adress);
    }

    internal interface ILesson4Api
    {
        void Run
    }

    class Lesson4Test
    {
        public void Test()
        {
            var api1 = new Lesson4Api(new InvoiceService());
            api1.Run();

            var api2 = new Lesson4ApiMethod();
            api2.Run(new InvoiceService());

            var api3 = new Lesson4Api(new MyInvoiceService());

            api3.Run();
        }
    }

    class Lesson4Api : ILesson4Api
    {
        private IInvoiceService _service;

        public Lesson4Api(IInvoiceService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.Pay(10);
            _service.Send("My address");
        }
    }

    class Lesson4ApiMethod : ILesson4ApiMethod
    {

        public void Run(IInvoiceService service)
        {
            service.Pay(10);
            service.Send("My address");
        }
    }

    class Lesson4ApiProperty:ILesson4Api
    {
        public IInvoiceService Service { set; get; }

        public void Run()
        {
            Service.Pay(10);
            Service.Send("My address");
        }
    }



    class InvoiceService : IInvoiceService
    {
        public void Pay(decimal amount)
        {

        }
        public void Send(string address)
        {

        }
    }

    class MyInvoiceService : IInvoiceService
    {
        public void Pay(decimal amount)
        {
            // Pay me
        }
        public void Send(string address)
        {
            // Send it from me
        }
    }

    class PresentConnectionInvoiceService : IInvoiceService
    {
        public void Pay(decimal amount)
        {
            // Request Peter
        }
        public void Send(string address)
        {
            // Send to outlook
        }
    }



}
