using Matrimony.Views.MailBox;
using Matrimony.Views.Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeContentView : ContentView
    {
        public SwipeContentView()
        {
            InitializeComponent();
        }

        private void HomePage_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }

        private void Matches_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatchesPage());
        }


        private void Mailbox_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MailBoxPage());
        }

        private void Notification_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationPage());
        }

        private void Help_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }

        private void Settings_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }
        private void Support_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Support());
        }
    }
}