using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class Stud
    {
        public string Nam { get; }
        public string Id { get; }
        public DateTime Birthday { get; }

        public int Age => (int)(Math.Ceiling((DateTime.Now - Birthday).TotalDays)) / 365;

        public Stud(string n, string i, DateTime b)
        {
            Nam = n;
            Id = i;
            Birthday = b;
        }

        // Studying.
        void DoAction()
        {
            Console.WriteLine("Studying");
        }
    }
}
