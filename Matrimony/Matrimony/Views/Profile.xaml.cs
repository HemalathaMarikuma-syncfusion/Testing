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
	public partial class Profile : ContentPage
	{
		public Profile ()
		{
			InitializeComponent ();            
        }

        private async void BtnLoadMatches_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matches.MatchesPage());
        }

        private async void BtnLoadRegistration_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.Registration.RegistationPage());
        }

        private async void BtnLoadEditProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.Registration.UpdateProfileDetailsPage());
        }

        private async void BtnLoadMailes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.MailBox.MailBoxPage());
        }

        private async void BtnProfilePhotos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.Common.ProfilePhotos());
        }
    }
}