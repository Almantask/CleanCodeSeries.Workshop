using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples
{
    class School
    {
        private IEnumerable<ClassRoom> _classRooms;

        public School(IEnumerable<ClassRoom> classRooms)
        {
            _classRooms = classRooms;
        }

        public void Run(Day day)
        {
            const int maxLessons = 8;
            for(var lesson = 0; lesson < maxLessons; lesson++)
                foreach (var classroom in _classRooms)
                {
                    try
                    {
                        classroom.Run(day, lesson);
                    }
                    catch
                    {
                        // Lessons are over. Go home :)
                    }
                
                }
        }
    }
}