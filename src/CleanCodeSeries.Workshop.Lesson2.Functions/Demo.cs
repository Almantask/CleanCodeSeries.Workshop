using CleanCodeSeries.Workshop.Lesson2.Functions.StaticHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCodeSeries.Workshop.Lesson2.Functions.GiftPicker;

namespace CleanCodeSeries.Workshop.Lesson2.Functions
{
    public class Demo
    {
        public void RunDemo()
        {
            DemoCollectionPrint();
            DemoGiftPicker();
        }

        private void DemoGiftPicker()
        {
            var gifts = new[] { new Gift("borwn", 7) };

            var giftForTom = GiftRandomiser.PickGift("Tom", "Male", 6, "brown", gifts);
            var giftForJane = GiftRandomiser.PickGift("Jane", "Male (used to be :))", 6, "red", gifts);
            var giftForBill = GiftRandomiser.PickGift("Bill", "Male", 6, "brown", gifts);
        }

        private void DemoCollectionPrint()
        {
            var list = new List<object>() { 1, 2, "a", new DataTable() };
            var array = new object[]{ 1, 2, "a", new DataTable() };

            var message1 = CollectionHelper.ToString(list);
            var message2 = CollectionHelper.ToString(array);
        }

    }
}
