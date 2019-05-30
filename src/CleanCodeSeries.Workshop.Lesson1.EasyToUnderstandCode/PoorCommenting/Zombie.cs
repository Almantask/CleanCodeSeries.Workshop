﻿namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    class Zombie
    {
        private Vector3 _location;

        internal Brains Brains { get; }

        // Here it seeks for brains, not head!!!
        public void Seek(Brains brains)
        {
            // doesn't work
            //while (!Equals(_location, brains.LocationCurrent))
            //{
            //    Thread.Sleep(1);
            //}
            // LocationCurrent
            var l = brains.Location;
            Move(l);
        }

        // Goes to location
        public void Move(Vector3 locationTo)
        {
            // moving to location
        }
    }
}
