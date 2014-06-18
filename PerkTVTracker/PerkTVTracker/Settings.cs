using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PerkTVTracker
{
    [Serializable]
    public class Settings
    {
        private List<Account> _accounts = new List<Account>();

        private Dictionary<Account, DataPoints> _dataPoints = new Dictionary<Account, DataPoints>();

        public void Initialize()
        {
            if (_accounts == null)
                _accounts = new List<Account>();
            if (_dataPoints == null)
                _dataPoints = new Dictionary<Account, DataPoints>();
            foreach(Account account in _accounts)
            {
                if (!_dataPoints.ContainsKey(account))
                    _dataPoints.Add(account, new DataPoints());
            }
        }

        public IReadOnlyCollection<Account> Accounts
        {
            get { return _accounts.AsReadOnly(); }
        }

        public IReadOnlyDictionary<Account, DataPoints> DataPoints
        {
            get { return _dataPoints; }
        }

        public bool HideLifetimePoints
        {
            get;
            set;
        }

        public void AddAccount(Account account)
        {
            if (_accounts.Contains(account))
            {
                throw new Exception();
            }

            _accounts.Add(account);
            _dataPoints.Add(account, new DataPoints());

            SaveSettings();
        }

        public void RemoveAccount(Account account)
        {
            _accounts.Remove(account);
            _dataPoints.Remove(account);

            SaveSettings();
        }

        public void SaveSettings()
        {
            using (var fs = File.Create("settings.bin"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }
    }
}
