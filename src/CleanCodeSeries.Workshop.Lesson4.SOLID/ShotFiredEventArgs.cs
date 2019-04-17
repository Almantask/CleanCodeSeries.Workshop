using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// When shot is fired, we need to pass shooter name and target name. Thus the args class.
    /// </summary>
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
