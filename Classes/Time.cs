using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    //Time Object Class
    public class Time
    {
        private int Hours;
        private int Minutes;
        private int Seconds;

        //Getter Hours
        public int GetHours()
        {
            return Hours;
        }
        //Setter Hours
        public void setHours(int hours)
        {
            this.Hours = hours;
        }

        //Getter Minutes
        public int GetMinutes()
        {
            return Minutes;
        }

        //Setter Minutes
        public void SetMinutes(int minutes)
        {
            this.Minutes = minutes;
        }

        //Getter Seconds
        public int GetSeconds()
        {
            return Seconds;
        }

        //Setter Seconds
        public void SetSeconds(int seconds)
        {
            this.Seconds = seconds;
        }
    }
}
