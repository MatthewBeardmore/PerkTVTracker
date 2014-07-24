using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerkTVTracker
{
    [Serializable]
    public class Account
    {
        public string Email;
        public string Password;
        public bool ShowOnGraph = true;
        public DataPoints DataPoints = new DataPoints();
        public LinearDataProcessor LinearDataProcessor = new LinearDataProcessor();
        public PerkSession Session;

        public override bool Equals(object obj)
        {
            var other = obj as Account;

            if (other == null)
            {
                return false;
            }

            return Email == other.Email && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode() ^ Password.GetHashCode();
        }
    }
}
