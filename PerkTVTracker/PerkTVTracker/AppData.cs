using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class AppData
    {
        public List<AccountData> Accounts;
        public AccountData Total;
    }

    [Serializable]
    public class AccountData
    {
        public string Email;
        public int CurrentPoints;
        public int LifetimePoints;
        public double EstimatedHourlyRate;
    }
}
