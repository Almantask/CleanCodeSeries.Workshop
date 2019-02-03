using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadCodeStructure
{
    class Mess
    {
            public void MessUp3Mini()
            {

            }

        public void Execute()
        {
            // It has to execute in the following order: 2, 1, 3
            MessUp2();
                MessUp1();
            MessUp3();
        }


        public void MessUp2Mini()
        {

        }

        private void MessUp3()
        {

            }

        private void MessUp1()
            {

        }

                private void MessUp2()
                {

                }

       // Ignored 
    }
}
