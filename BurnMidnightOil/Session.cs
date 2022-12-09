using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BurnMidnightOil
{
    public abstract class Session
    {
        public Random rand;
        internal Action<string> logSetter;

        public Time MaxTime { get; }
        public Time DelayTime { get; }

        public Session(Action<string> logSetter, Time delayTime, Time maxTime = null)
        {
            rand = new Random();
            this.logSetter = logSetter;
            DelayTime = delayTime;
            MaxTime = maxTime;
        }
    }
}
