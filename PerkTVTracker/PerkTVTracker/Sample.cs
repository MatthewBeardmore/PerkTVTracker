using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class Sample
    {
        public Sample() { }

        public Sample(int pointCount, int lifetimePointCount, DateTime time)
        {
            PointCount = pointCount;
            LifetimePointCount = lifetimePointCount;
            Time = time;
        }

        public int PointCount;
        public int LifetimePointCount;
        public DateTime Time;
    };
}
