using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public abstract class TimeFormatCreator
    {
       
        public abstract ITimeConverter ConvertTime(string format);


    }
}
