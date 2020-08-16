using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Matrimony.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FPAuthentication : ContentPage
	{
		public FPAuthentication ()
		{
			InitializeComponent ();
            StartFPAuthentication();

        }

        private async void StartFPAuthentication()
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(false);
            if (result)
            {
                var AuthRequestConfig = new AuthenticationRequestConfiguration("Please verify your fingerprint")
                {
                    UseDialog = false
                };
                //var AuthRequestConfig = new AuthenticationRequestConfiguration("")
                //{
                //    UseDialog = false
                //};
                //{
                //    AllowAlternativeAuthentication = true
                //};
                //var AuthRequestConfig = new AuthenticationRequestConfiguration("Please verify your fingerprint")
                //{
                //    UseDialog = false
                //};

                var auth = await CrossFingerprint.Current.AuthenticateAsync(AuthRequestConfig);

                if (auth.Authenticated)
                {
                     Navigation.PushAsync(new Profile());
                }
            }
            else
            {
                await DisplayAlert("Authentication Failed", "Fingerprint Authentication Not Added", "OK");
            }
        }

    }
}