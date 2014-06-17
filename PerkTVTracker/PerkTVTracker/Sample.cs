using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    public struct Sample
    {
        public Sample(int pointCount, DateTime time)
        {
            PointCount = pointCount;
            Time = time;
        }

        public int PointCount;
        public DateTime Time;
    };
}
