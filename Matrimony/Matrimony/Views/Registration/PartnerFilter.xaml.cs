using Matrimony.ViewModels;
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
	public partial class PartnerFilter : ContentPage
	{
        public PartnerFilter()
        {
            InitializeComponent();
            UpdateProfileViewModel profileViewModel = new UpdateProfileViewModel();
            this.BindingContext = profileViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateProfileDetailsPage() { BindingContext = this.BindingContext });
        }
    }
}