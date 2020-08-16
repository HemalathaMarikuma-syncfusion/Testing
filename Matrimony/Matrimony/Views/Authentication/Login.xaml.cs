using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private async void RegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.Registration.RegistationPage());
        }

        private async void OTP_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "Vannukanum..", "OK");
        }

        private async void ForgotPassword_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "Kalanjittu veree valla panikkum poodey..", "OK");
        }

        private  void Register_Tapped(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Matrimony.Views.Profile());
        }

        private void Password_Tapped(object sender, EventArgs e)
        {
            enrtyPassword.IsPassword = !enrtyPassword.IsPassword;
            if (imageShowPassword.IsVisible == true)
            {
                imageShowPassword.IsVisible = false;
                imageHidePassword.IsVisible = true;
            }
            else
            {
                imageShowPassword.IsVisible = true;
                imageHidePassword.IsVisible = false;
            }
        }
    }
}