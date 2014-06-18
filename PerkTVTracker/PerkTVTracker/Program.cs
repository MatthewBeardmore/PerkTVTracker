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
            _settings = Settings.LoadSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
