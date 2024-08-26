using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Microondas.util
{
    public static class ConverteTimer
    {
        public static int converteTimer(int tempoRestante)
        {
            string timeString = tempoRestante.ToString();
            int totalSeconds;
            if (timeString.Length == 4)
            {
                int minutes = int.Parse(timeString.Substring(0, 2));
                int seconds = int.Parse(timeString.Substring(2, 2));

                if (seconds >= 60)
                {
                    totalSeconds = (minutes * 60) + seconds;
                }
                else
                {
                    totalSeconds = (minutes * 60) + seconds;
                }
            }
            else if (timeString.Length == 3)
            {
                int minutes = int.Parse(timeString.Substring(0, 1));
                int seconds = int.Parse(timeString.Substring(1, 2));

                if (seconds >= 60)
                {
                    totalSeconds = (minutes * 60) + seconds;
                }
                else
                {
                    totalSeconds = (minutes * 60) + seconds;
                }
            }
            else if (timeString.Length == 2)
            {
                totalSeconds = int.Parse(timeString);
            }
            else
            {
                totalSeconds = int.Parse(timeString);
            }

            return totalSeconds;
        }
    }
}
