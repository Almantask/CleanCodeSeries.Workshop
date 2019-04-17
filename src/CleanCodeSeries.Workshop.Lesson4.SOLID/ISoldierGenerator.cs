using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    public interface ISoldierGenerator
    {
        IList<Soldier> Generate();
    }
}