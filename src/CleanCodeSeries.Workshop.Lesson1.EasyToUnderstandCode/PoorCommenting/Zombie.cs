namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    class Zombie
    {
        private Head _head;

        private Vector3D _location;

        public void Seek(Head head)
        {
            Move(head.Location);
        }

        public void Move(Vector3D locationTo)
        {
            //TODO: 
            // moving to location
        }
    }
}
