using Matrimony.Models;
using Matrimony.Models.Constant;
using Matrimony.Views.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePhotos : ContentPage
    {

        public ProfilePhotos()
        {
            InitializeComponent();
        }

        private void ShortlistGesture_Tapped(object sender, EventArgs e)
        {

        }

        private void SkipGesture_Tapped(object sender, EventArgs e)
        {

        }

        private void SendInterestGesture_Tapped(object sender, EventArgs e)
        {

        }

        private void ProfileGesture_Tapped(object sender, EventArgs e)
        {
            Models.MatchProfile matche = new Models.MatchProfile();
            Models.Constant.Page page = new Models.Constant.Page();
            //App.NavigatePage(page, matche);
        }
    }
}