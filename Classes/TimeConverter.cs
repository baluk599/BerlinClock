using BerlinClock.BerlinTimeFormatCreators;
using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BerlinClock
{
   public class TimeConverter : TimeFormatCreator
    {
       
        // Dependency Injection for Setting the input Time Format
        //Dependency Injection for Setting the output Time Format
        public override ITimeConverter ConvertTime(string aTime)
        {
            return new ConvertBerlinClock();
        }
    }
}
