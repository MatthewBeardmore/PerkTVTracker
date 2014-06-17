using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerkTVTracker
{
    public static class Program
    {
        private static Settings _settings;

        public static Settings Settings
        {
            get { return _settings; }
        }
        public static readonly DateTime START_TIME = DateTime.Now;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Deserialize settings file
            try
            {
                using (var fs = File.OpenRead("settings.bin"))
                {
                    var formatter = new BinaryFormatter();
                    _settings = formatter.Deserialize(fs) as Settings;
                    _settings.Initialize();
                }
            }
            catch
            {
                // Create the settings file
                _settings = new Settings();

                _settings.SaveSettings();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
