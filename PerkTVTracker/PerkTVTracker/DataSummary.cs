using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class DataSummary
    {
        public int PointCount;
        public int LifetimePointCount;
        public double HourlyRate;
        public DateTime LastSampleTimestamp;

        public DataSummary Copy()
        {
            return new DataSummary()
            {
                PointCount = this.PointCount,
                LifetimePointCount = this.LifetimePointCount,
                HourlyRate = this.HourlyRate,
                LastSampleTimestamp = this.LastSampleTimestamp
            };
        }
    }
}
