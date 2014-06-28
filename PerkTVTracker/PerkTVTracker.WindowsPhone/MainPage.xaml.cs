using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PerkTVTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

            reprompt:
            if(!ApplicationData.Current.LocalSettings.Values.Keys.Contains("IPAddress"))
            {
                IPAddressPrompt prompt = new IPAddressPrompt();
                await prompt.ShowAsync(); 
            }
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += timer_Tick;
            timer.Start();

            try
            {
                await UpdateUI();
            }
            catch
            {
                ApplicationData.Current.LocalSettings.Values.Remove("IPAddress");
                goto reprompt;
            }
        }

        async void timer_Tick(object sender, object e)
        {
            try
            {
                await UpdateUI();
            }
            catch { }
        }

        private async Task UpdateUI()
        {
            string ipAddress = ApplicationData.Current.LocalSettings.Values["IPAddress"].ToString();

            using (HttpClient hc = new HttpClient())
            {
                var response = await hc.PostAsync(new Uri("http://" + ipAddress + ":10000/app"), null);
                var resultString = await response.Content.ReadAsStringAsync();

                using (IInputStream stream = await response.Content.ReadAsInputStreamAsync())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppData));
                    AppData appData = (AppData)serializer.Deserialize(stream.AsStreamForRead());

                    if (pivot.Items.Count == 0)
                    {
                        PivotItem pivotItem = new PivotItem();
                        pivotItem.Header = "Total";
                        pivotItem.FontSize = 18;
                        pivotItem.Content = new TotalInfoControl();
                        pivot.Items.Add(pivotItem);

                        foreach (AccountData account in appData.Accounts)
                        {
                            pivotItem = new PivotItem();
                            pivotItem.Header = "Account #" + pivot.Items.Count;
                            pivotItem.FontSize = 18;
                            pivotItem.Content = new AccountInfoControl();
                            pivot.Items.Add(pivotItem);
                        }
                    }

                    ((TotalInfoControl)((PivotItem)pivot.Items[0]).Content).Update(appData.Total);

                    int i = 1;
                    foreach(AccountData account in appData.Accounts)
                    {
                        ((AccountInfoControl)((PivotItem)pivot.Items[i++]).Content).Update(account);
                    }
                }
            }
        }
    }
}
