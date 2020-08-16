using Matrimony.Notification.Toasts;
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
    public partial class RegistationPage : ContentPage
    {
        public RegistationPage()
        {
            InitializeComponent();

            RegistrationViewModel regViewModel = new RegistrationViewModel();
            DayList.BindingContext = regViewModel;
            MonthList.BindingContext = regViewModel;
            YearList.BindingContext = regViewModel;
        }

        private void sampleList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            authorsListView.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            authorsListView.IsVisible = true;
        }

        private void Day_Tapped(object sender, EventArgs e)
        {
            DayView.IsVisible = true;
        }

        private void Month_Tapped(object sender, EventArgs e)
        {
            MonthView.IsVisible = true;
        }

        private void Year_Tapped(object sender, EventArgs e)
        {
            YearView.IsVisible = true;
        }      

        private void MotherTongueTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            MotherTongueView.IsVisible = true;
        }

        private void malecheck_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value.ToString() == "True")
            {
                frameMale.BorderColor = Color.Accent;
                frameFemale.BorderColor = Color.Gray;
                checkFemale.IsChecked = false;
            }
        }

        private void femalecheck_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value.ToString() == "True")
            {
                frameFemale.BorderColor = Color.Accent;
                frameMale.BorderColor = Color.Gray;
                checkMale.IsChecked = false;
            }
        }

        private void DayList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DayView.IsVisible = false;
            var date = (e.Item as RegistrationModel).Date;
            entryDay.Text = date;
        }

        private void MonthList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MonthView.IsVisible = false;
            var month = (e.Item as RegistrationModel).Month;
            MonthEntry.Text = month;
        }

        private void YearList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            YearView.IsVisible = false;
            var year = (e.Item as RegistrationModel).Year;
            YearEntry.Text = year;
        }

        private void ReligionList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ReligionView.IsVisible = false;
        }

        private void MotherTonguelist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MotherTongueView.IsVisible = false;
        }

        private void CountryCodelist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CountryCodeView.IsVisible = false;
        }



        #region ContentView Tapped

        private void AuthorsContentViewTapped(object sender, EventArgs e)
        {
            authorsListView.IsVisible = false;
        }

        private void DayContentViewTapped(object sender, EventArgs e)
        {
            DayView.IsVisible = false;
        }

        private void MonthContentViewTapped(object sender, EventArgs e)
        {
            MonthView.IsVisible = false;
        }

        private void YearViewContentTapped(object sender, EventArgs e)
        {
            YearView.IsVisible = false;
        }

        private void ReligionContentViewTapped(object sender, EventArgs e)
        {
            ReligionView.IsVisible = false;
        }

        private void MotherTongueContentViewTapped(object sender, EventArgs e)
        {
            MotherTongueView.IsVisible = false;
        }

        private void CountryCodeContentTapped(object sender, EventArgs e)
        {
            CountryCodeView.IsVisible = false;
        }

        #endregion

        private void Password_Tapped(object sender, EventArgs e)
        {
            //entryPassword.IsPassword = !entryPassword.IsPassword;
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

        private void PolicyTapped(object sender, EventArgs e)
        {

        }

        private async void Login_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Matrimony.Views.Authentication.Login());
        }

        private void MobileNo_Tapped(object sender, EventArgs e)
        {
            string message = "[Privacy importance] "+ Environment.NewLine +"After registration, there have an option to hide your mobile number";
            DependencyService.Get<IToastMessage>().LongTime(message);
            //DependencyService.Get<IToastMessage>().ShortTime(message);
        }

        private void Religion_Tapped(object sender, EventArgs e)
        {
            ReligionView.IsVisible = true;
        }

        private void MotherTongue_Tapped(object sender, EventArgs e)
        {
            MotherTongueView.IsVisible = false;
        }

        private void CountryCode_Tapped(object sender, EventArgs e)
        {
            CountryCodeView.IsVisible = true;
        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {

        }
    }
}