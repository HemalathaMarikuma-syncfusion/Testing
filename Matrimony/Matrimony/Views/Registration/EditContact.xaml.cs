using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContact : ContentPage
    {
        public EditContact()
        {
            InitializeComponent();
        }

        private void Email_Tapped(object sender, EventArgs e)
        {
            EmailView.IsVisible = true;
        }

        private void Phone_Tapped(object sender, EventArgs e)
        {
            PhonenumberView.IsVisible = true;
        }
        private void AlternatePhone_Tapped(object sender, EventArgs e)
        {
            AlternatePhonenumberView.IsVisible = true;
        }
        private void EmailViewOK_Tapped(object sender, EventArgs e)
        {
            EmailView.IsVisible = false;
        }
        private void EmailViewCancel_Tapped(object sender, EventArgs e)
        {
            EmailEntry.Text = "abcdgmail.com";
            EmailView.IsVisible = false;
        }
        private void PhonenumberViewOK_Tapped(object sender, EventArgs e)
        {
            PhonenumberView.IsVisible = false;
        }
        private void PhonenumberViewCancel_Tapped(object sender, EventArgs e)
        {
            PhonenumberEntry.Text = "01234567890";
            PhonenumberView.IsVisible = false;
        }
        private void AlternatePhonenumberView_Tapped(object sender, EventArgs e)
        {
            AlternatePhonenumberView.IsVisible = false;
        }
        private void AlternatePhonenumberViewOK_Tapped(object sender, EventArgs e)
        {
            AlternatePhonenumberView.IsVisible = false;
        }
        private void AlternatePhonenumberViewCancel_Tapped(object sender, EventArgs e)
        {
            AlternatePhonenumberEntry.Text = "";
            AlternatePhonenumberView.IsVisible = false;
        }

    }
}