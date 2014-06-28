using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers.Provider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PerkTVTracker
{
    public sealed partial class IPAddressPrompt : ContentDialog
    {
        private Frame Frame;

        public IPAddressPrompt()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            ApplicationData.Current.LocalSettings.Values["IPAddress"] = ipAddress.Text;
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if(ApplicationData.Current.LocalSettings.Values.Keys.Contains("IPAddress"))
            {
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                body.Text = "You must enter an IP address to continue.";
                args.Cancel = true;
            }
        }
    }
}
