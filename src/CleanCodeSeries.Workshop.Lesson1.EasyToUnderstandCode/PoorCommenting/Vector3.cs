namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    public struct Vector3D
    {
        private float _x;
        public float Y { get; }
        public float Z { get; }

        public Vector3D(float x, float y, float z)
        {
            _x = x;
            Y = y;
            Z = z;
        }

    }
}
