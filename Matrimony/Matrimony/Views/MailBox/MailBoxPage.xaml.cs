using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.MailBox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MailBoxPage : ContentPage
    {
        public MailBoxPage()
        {
            InitializeComponent();
        }

        private void BackArrow_Tapped(object sender, EventArgs e)
        {

        }

        private void ListViewMail_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ListViewMail_ItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {

        }

        private void TapAccept_Tapped(object sender, EventArgs e)
        {

        }

        private void TapReject_Tapped(object sender, EventArgs e)
        {

        }

        private void SentGesture_Tapped(object sender, EventArgs e)
        {
            ManageSentReceivedSwitch(true);
        }

        private void ReceivedGesture_Tapped(object sender, EventArgs e)
        {
            ManageSentReceivedSwitch(false);
        }

        private void ManageSentReceivedSwitch(bool IsSent)
        { 
            if(IsSent)
            {
                frameReceived.BackgroundColor = Color.White;
                frameSent.BackgroundColor = Color.Green;
                lblReceived.TextColor = Color.Black;
                lblSent.TextColor = Color.White;
            }
            else
            {
                frameReceived.BackgroundColor = Color.Green;
                frameSent.BackgroundColor = Color.White;
                lblReceived.TextColor = Color.White;
                lblSent.TextColor = Color.Black;
            }
        }
        
    }
}