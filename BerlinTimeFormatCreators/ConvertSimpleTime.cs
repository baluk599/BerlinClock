using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerlinClock.Classes;

namespace BerlinClock.BerlinTimeFormatCreators
{
    class ConvertSimpleTime 
    //class ConvertSimpleTime 
    {
        //Accepts String to convert Simple Input Format hh:mm:ss to Time Object, Throws Application Exception for wrong format
        public Time ConvertInputTime(string aTime)
        {
            string[] timeValues = aTime.Split(new string[] { ":" }, StringSplitOptions.None);
            Time t = new Time();
            t.setHours(Int32.Parse(timeValues[0]));
            t.SetMinutes(Int32.Parse(timeValues[1]));
            t.SetSeconds(Int32.Parse(timeValues[2]));
            return t;
        }

        //Accepts Time Object to Output Simple Format hh:mm:ss as a String
        public string ConvertOutputTime(Time aTime)
        {
            return aTime.GetHours() + ":" + aTime.GetMinutes() + ":" + aTime.GetSeconds();
        }

        public string convertTime(Time aTime)
        {
            return aTime.GetHours() + ":" + aTime.GetMinutes() + ":" + aTime.GetSeconds();
        }
    }
}
