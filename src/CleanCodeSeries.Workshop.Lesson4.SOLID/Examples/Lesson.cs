using System;
using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples
{
    public class Lesson
    {
        IEnumerable<Student> _students;
        public Lesson(IEnumerable<Student> students)
        {
            this._students = students;
        }

        public void Run()
        {
            RingBell();
            Gather(_students);
            Teach(_students);
            RingBell();
            Release(_students);
        }

        private void Start()
        {
            RingBell();
            Gather(_students);
        }

        private void End()
        {
            RingBell();
            Release(_students);
        }

        private void Release(IEnumerable<Student> enumerable)
        {
            throw new NotImplementedException();
        }

        private void Teach(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        private void Gather(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        private void RingBell()
        {
            throw new NotImplementedException();
        }
    }
}
