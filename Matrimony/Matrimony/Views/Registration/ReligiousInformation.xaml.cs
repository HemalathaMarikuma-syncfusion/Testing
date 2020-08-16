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
	public partial class ReligiousInformation : ContentPage
	{
		public ReligiousInformation ()
		{
			InitializeComponent ();
		}

        private async void RasiPicker_Tapped(object sender, EventArgs e)
        {
            if (StarPicker.SelectedItem != null)
            {

            }
            else
            {
                await DisplayAlert("Raasi", "Select One Star", "O.K");
            }
        }

    }
}