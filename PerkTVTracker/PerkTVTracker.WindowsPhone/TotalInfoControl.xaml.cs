using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PerkTVTracker
{
    public sealed partial class TotalInfoControl : UserControl
    {
        public TotalInfoControl()
        {
            this.InitializeComponent();
        }

        public void Update(AccountData account)
        {
            pointCount.Text = account.CurrentPoints.ToString("#,##0 pts");
            if (account.LifetimePoints > 0)
            {
                pointCount.Text += account.LifetimePoints.ToString(" (of #,##0)");
            }

            int hourlyRate = (int)Math.Round(account.EstimatedHourlyRate);
            string formattedHourly = hourlyRate.ToString("#,##0");
            this.hourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "pts" : "pt");
        }
    }
}
