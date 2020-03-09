using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock.Classes;

namespace BerlinClock.BerlinTimeFormatCreators
{
    public class DefaultTimeFormat 
    {
        //Default Input Format not Implemented or if not Input Format not Recognized, Throws Application Exception
        public Time convertInputTime(string aTime)
        {
            throw new ApplicationException(string.Format("Input Time Format not Supported Yet!"));
        }

        //Default Output Format not Implemented or if not Input Format not Recognized, Throws Application Exception
        public string convertOutputTime(Time aTime)
        {
            throw new ApplicationException(string.Format("Ouptut Time Format not Supported Yet!"));
        }
    }
}
