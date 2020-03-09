using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BerlinClock.BerlinTimeFormatCreators
{
    public class ConvertBerlinClock : ITimeConverter
    {
        private String color1 = "Y"; //Yellow Color
        private String color2 = "R"; //Red Color
        private String colorOff = "O"; //Off Color

     
        //Accepts Time Object to Output Berlin Clock Format String - L to R
        public string ConvertTime(Time aTime)
        {
            return GetSeconds(aTime.GetSeconds()) + " " + GetHours(aTime.GetHours()) + " " + GetMinutes(aTime.GetMinutes());
        }

        //Converts Hours - Second and Third Rows
        private String GetHours(int hours)
        {
            return GetLampState(4, (hours - (hours % 5)) / 5) + " " + GetLampState(4, hours % 5);
        }

        //Converts Minutes - Bottom Two Rows
        private String GetMinutes(int minutes)
        {
            return Regex.Replace(GetLampState(11, (minutes - (minutes % 5)) / 5, color1), color1 + color1 + color1, color1 + color1 + color2) + " " +
                GetLampState(4, minutes % 5, color1);
        }

        //Converts Seconds - Top Row
        private String GetSeconds(int seconds)
        {
            if (seconds % 2 == 0)
                return color1;
            else
                return colorOff;
        }

        //Checks Whether the Lamp is On/Off
        private String GetLampState(int lamps, int onLight)
        {
            return GetLampState(lamps, onLight, color2);
        }

        //Checks Whether the Lamp is On/Off
        private String GetLampState(int lamps, int onLights, String onLight)
        {
            String output = "";
            for (int i = 0; i < onLights; i++)
            {
                output += onLight;
            }
            for (int i = 0; i < (lamps - onLights); i++)
            {
                output += colorOff;

            }
            return output;
        }

       
    }
}
