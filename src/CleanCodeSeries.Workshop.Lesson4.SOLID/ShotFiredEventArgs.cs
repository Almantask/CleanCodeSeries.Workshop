using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    public class ShotFiredEventArgs : EventArgs
    {
        public string ShooterName { set; get; }
        public string TargetName { set; get; }

        public ShotFiredEventArgs(string shooterName, string targetName)
        {
            ShooterName = shooterName;
            TargetName = targetName;
        }
    }

}
