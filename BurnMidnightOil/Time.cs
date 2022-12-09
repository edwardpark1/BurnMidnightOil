using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnMidnightOil
{
    public class Time
    {
        private int time;

        public int TotalSeconds 
        {
            get 
            { 
                return time; 
            }

            private set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                time = value;
            }
        }
        
        public int Seconds 
        { 
            get
            {
                return TotalSeconds % 60;
            }
        }

        public int Minutes 
        { 
            get
            {
                return (TotalSeconds % 3600) / 60;
            }
        }
        
        public int Hours 
        {
            get
            {
                return TotalSeconds / 3600;
            } 
        }

        public Time (int totalTime)
        {
            SetTime(totalTime);
        }

        public Time (int hours, int minutes, int seconds)
            : this(seconds + (minutes * 60) + (hours * 3600))
        {

        }

        private void SetTime(int timeVal)
        {
            TotalSeconds = timeVal;
        }

        public void TimePass()
        {
            TotalSeconds--;
        }
    }
}
