using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class Order
    {
        public Header Head { get; }
        public IEnumerable<Item> Items { get; }

        public Order(Header head)
        {
            Items = new List<Item>();
            Head = head;
        }

        public override string ToString()
        {
            var txt = "";
            txt += Head.ToString();
            var itms = Items.ToArray();
            for (int i = 0; i < Items.Count(); i++)
            {
                txt += itms[i].ToString();
            }

            return txt;
        }

        public void Process(bool isDecline)
        {
            if(isDecline)
                Console.WriteLine("Declined");
            //else
            //{
            //    Console.WriteLine("Accepted");
            //}
        }

        public Item GetItemById(string id)
        {
            return new Item();
        }

        public IEnumerable<Item> GetAllItems()
        {
            return Items;
        }
    }
}
