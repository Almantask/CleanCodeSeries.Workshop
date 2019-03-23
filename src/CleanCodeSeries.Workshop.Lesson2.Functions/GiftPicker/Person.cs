using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.GiftPicker
{
    public struct Person
    {
        public readonly string Name;
        public readonly Gender Gender;
        public readonly int Age;
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    } 
}
