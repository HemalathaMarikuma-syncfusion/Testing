using Matrimony.ViewModels;
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

        private  void BtnLoadMatches_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Matches.MatchesPage());
        }

        private  void BtnLoadRegistration_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Matrimony.Views.Registration.RegistationPage());
        }

        private  void BtnLoadEditProfile_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Matrimony.Views.Registration.UpdateProfileDetailsPage());
        }

        private  void BtnLoadMailes_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Matrimony.Views.MailBox.MailBoxPage());
        }

        private  void BtnProfilePhotos_Clicked(object sender, EventArgs e)
        {
            //If no more photo selected in that case, it shows its default image
             Navigation.PushAsync(new Matrimony.Views.Common.ProfilePhotos() { BindingContext = new PhotosViewModel() });
        }
    }
}