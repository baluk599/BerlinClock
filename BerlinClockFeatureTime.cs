using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
   public class BerlinClockFeatureTime
    {
        TimeFormatCreator factory = new TimeConverter();

        //ITimeConverter inputFormat;
        Time inputTime;

        public string BerlinClockOutput(string time)
        {           
            ITimeConverter outputFormat = factory.ConvertTime(time);
            string output = outputFormat.ConvertTime(inputTime);
            return output;

        }
    }
}
