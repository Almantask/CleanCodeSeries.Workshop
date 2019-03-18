using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    class Order
    {
        public Header Head;
        public IEnumerable<Item> Items;

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
            => Items.FirstOrDefault(item => item.Id == id);

        public IEnumerable<Item> GetAllItems()
        {
            return Items;
        }
    }
}
