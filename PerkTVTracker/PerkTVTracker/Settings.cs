using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

        [XmlIgnore]
        public TimeSpan SampleAgeLimit { get; set; }

        // XmlSerializer does not support TimeSpan, so use this property for 
        // serialization instead. Do not use this in code; use SampleAgeLimit instead.
        // http://stackoverflow.com/a/6734557
        [XmlElement(DataType = "duration", ElementName = "SampleAgeLimitString")]
        public string SampleAgeLimitString
        {
            get
            {
                return XmlConvert.ToString(SampleAgeLimit);
            }
            set
            {
                SampleAgeLimit = string.IsNullOrEmpty(value) ?
                    TimeSpan.Zero : XmlConvert.ToTimeSpan(value);
            }
        }

        public bool ShowTotalInformation { get; set; }

        public int MainWindowSplitterDistance { get; set; }

        public Settings()
        {
            MinimizeToTray = true;
            ShowTotalInformation = true;
            SampleAgeLimit = new TimeSpan(1, 0, 0); // Default of 1 hour
        }

        public void AddAccount(Account account)
        {
            if (_accounts.Contains(account))
            {
                throw new Exception();
            }

            account.LinearDataProcessor.SampleAgeLimit = SampleAgeLimit;

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

            // Set the sample age limits for each account
            foreach (var account in settings.Accounts)
            {
                account.LinearDataProcessor.SampleAgeLimit = settings.SampleAgeLimit;
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
