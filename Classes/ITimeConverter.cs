using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public interface ITimeConverter
    {
      String ConvertTime(Time aTime);
        //Converts Input String to Time Object
        //Time convertInputTime(string aTime);

        ////Converts Time Object to Given Output Format
        //String convertOutputTime(Time aTime);

    }
}
