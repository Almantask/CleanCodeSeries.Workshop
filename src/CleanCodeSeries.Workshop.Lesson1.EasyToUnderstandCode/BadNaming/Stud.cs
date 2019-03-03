using System;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class Stud
    {
        public string Nam { get; }
        public string Id { get; }
        public DateTime Bday { get; }

        public int Age => (int)(Math.Ceiling((DateTime.Now - Bday).TotalDays)) / 365;

        public Stud(string n, string i, DateTime b)
        {
            Nam = n;
            Id = i;
            Bday = b;
        }

        // Studying.
        void DoAction()
        {
            Console.WriteLine("Studying");
        }
    }
}
