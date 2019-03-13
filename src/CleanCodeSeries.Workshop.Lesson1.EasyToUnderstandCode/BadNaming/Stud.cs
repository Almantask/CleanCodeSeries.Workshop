using System;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    class Stud
    {
        public string Nam { get; }
        public string Id { get; }
        public DateTime Bday { get; }

        public int Age => CalculateAge(Bday);

        public Stud(string n, string i, DateTime b)
        {
            Nam = n;
            Id = i;
            Bday = b;
        }

        private int CalculateAge(DateTime bday)
        {
            var ageInDays = (DateTime.Now - bday).TotalDays;
            return (int)(Math.Ceiling(ageInDays)) / 365;
        }

        void Study()
        {
            Console.WriteLine("Studying");
        }
    }
}
