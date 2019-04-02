using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples
{
    class ClassRoom
    {
        private Dictionary<Day, IList<Lesson>> _schedule;

        public ClassRoom(Dictionary<Day, IList<Lesson>> schedule)
        {
            _schedule = schedule;
        }

        public void Run(Day day, int lessonIndex)
        {
            if (!_schedule.ContainsKey(day))
                throw new Exception($"No lessons on {day}");

            var lessons = _schedule[day];
            if (lessons.Count() <= lessonIndex)
                throw new Exception($"Lessons are already over. No {lessonIndex}th lesson.");

            var lesson = lessons[lessonIndex];
            lesson.Run();
        }
    }
}