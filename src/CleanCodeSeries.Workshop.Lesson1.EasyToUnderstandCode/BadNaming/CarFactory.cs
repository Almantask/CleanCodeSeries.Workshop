using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    public class CarFactory
    {
        public Car SetCar()
        {
            return new Car(100, 50, "F", 5, new Vector3(0, 0, 0));
        }


    }
}
