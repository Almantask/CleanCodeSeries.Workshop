namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.NoEncapsulation
{
    class PaperPlane
    {
        public string Name;
        public string Description;
        public float Length;
        public float Width;
        public float Height;
        public float Speed;

        public float X;
        public float Y;
        public float Z;

        public void SimulateFly(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            while (!(x1 - x2 < 0.001) && y1 - y2 > 0.001 && z1 - z2 > 0.001)
            {
                Fly(x1, y1, z1);
            }
        }

        public void Fly(float x, float y, float z)
        {
            X += x * Speed;
            Y += y * Speed;
            Z += z * Speed;
        }
    }
}
