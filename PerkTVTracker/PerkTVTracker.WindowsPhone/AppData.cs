using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    public class AppData
    {
        public List<AccountData> Accounts;
        public AccountData Total;
    }

    public class AccountData
    {
        public string Email;
        public int CurrentPoints;
        public int LifetimePoints;
        public double EstimatedHourlyRate;
    }
}
