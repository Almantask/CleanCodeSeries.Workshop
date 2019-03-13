namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadCodeStructure
{
    class Mess
    {
        public void Execute()
        {
            MessUp2();
            MessUp1();
            MessUp3();
        }

        private void MessUp2()
        {
            MessUp2Mini();
        }

        public void MessUp2Mini()
        {

        }

        private void MessUp1()
        {

        }

        private void MessUp3()
        {
            MessUp3Mini();
        }

        public void MessUp3Mini()
        {

        }
        
    }
}
