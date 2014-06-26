using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerkTVTracker
{
    [Serializable]
    public class Settings
    {
        private List<Account> _accounts = new List<Account>();

        public IReadOnlyCollection<Account> Accounts
        {
            get { return _accounts.AsReadOnly(); }
        }

        public List<Account> XmlAccounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        public bool HideLifetimePoints
        {
            get;
            set;
        }

        public bool MinimizeToTray
        {
            get;
            set;
        }

        public bool ClearDataPointsOnStartup
        {
            get;
            set;
        }

        public System.Windows.Forms.FormWindowState LastWindowState
        {
            get;
            set;
        }

        public Size LastWindowSize
        {
            get;
            set;
        }

        public Point LastWindowLocation
        {
            get;
            set;
        }

        public DateTime GraphMinimum
        {
            get;
            set;
        }

        public DateTime GraphMaximum
        {
            get;
            set;
        }

        public GraphType GraphType
        {
            get;
            set;
        }

        public Settings()
        {
            MinimizeToTray = true;
        }

        public void AddAccount(Account account)
        {
            if (_accounts.Contains(account))
            {
                throw new Exception();
            }

            _accounts.Add(account);

            SaveSettings();
        }

        public void RemoveAccount(Account account)
        {
            _accounts.Remove(account);

            SaveSettings();
        }

        public static Settings LoadSettings()
        {
            Settings settings;
            try
            {
                using (var fs = File.OpenRead("settings.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(fs) as Settings;
                    if (settings.ClearDataPointsOnStartup)
                        foreach (Account account in settings.Accounts)
                            account.DataPoints.ClearPoints();
                }
            }
            catch
            {
                // Create the settings file
                settings = new Settings();

                settings.SaveSettings();
            }
            return settings;
        }

        public DataPoints GetDataPointsForAccount(Account account)
        {
            foreach (Account acc in Accounts)
                if (acc == account)
                    return acc.DataPoints;
            return null;
        }

        public void SaveSettings()
        {
            using (var fs = File.Create("settings.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(fs, this);
            }
        }
    }
}
