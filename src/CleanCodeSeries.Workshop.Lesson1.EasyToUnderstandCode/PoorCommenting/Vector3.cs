namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    public struct Vector3
    {
        // Horizontal
        public float X { get; }
        // Vertical
        public float Y { get; }
        // Depth
        public float Z { get; }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

    }
}
