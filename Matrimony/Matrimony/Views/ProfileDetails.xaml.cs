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
    public partial class ProfileDetails : ContentPage
    {

        Models.MatchProfile Profile = new Models.MatchProfile();        

        public ProfileDetails(Models.MatchProfile match)
        {
            InitializeComponent();
            Profile = match;
            //var ImageSource = new UriImageSource { BindingContext = Dummy_LoadImages()};
            //ImageSource.CachingEnabled = false;
            //CarouselViewImages.ItemsSource = ImageSource;
            //CarouselViewImages.ItemsSource = Dummy_LoadImages();
            //Dummy_ProfileDetails();
        }

        #region Dummy

        private List<string> Dummy_LoadImages()
        {
            return new List<string>()
                {
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/600",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/900",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/800",
                    "https://picsum.photos/400/600",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/700",
                    "https://picsum.photos/400/700"
                };
        }

        private void Dummy_ProfileDetails()
        {
            try
            {
                LblName.Text = "Podey podey";
                LblMatrimonyID.Text = Profile.ProfileID ?? string.Empty;
                LblAge.Text = Profile.Age ?? string.Empty;
                LblHeight.Text = Profile.Height ?? string.Empty;
                LblLocation.Text = Profile.Location ?? string.Empty;
                string gender = Profile.Profile.PersonalInfo.BasicDetails.Gender ?? string.Empty;
                LblAboutGender.Text = "About " + (gender != "" ? gender == "Male" ? "Him" : gender == "Female" ? "Her" : "Person" : "");
                LblAboutYou.Text = Profile.Profile.PersonalInfo.AboutYou ?? string.Empty;

                LblYear.Text = "28 years";
                LblMonth.Text = "8 months";
                LblHeight1.Text = string.Format("{0}\' {1}\"", 5, 4);

                LblWeight.Text = Profile.Profile.PersonalInfo.BasicDetails.Weight ?? string.Empty + ",";
                LblBodyType.Text = Profile.Profile.PersonalInfo.BasicDetails.BodyType ?? string.Empty + ",";
                LblComplexion.Text = Profile.Profile.PersonalInfo.BasicDetails.Complexion ?? string.Empty;
                LblMaterialStatus.Text = Profile.Profile.PersonalInfo.BasicDetails.MaterialStatus ?? string.Empty;
                LblMotherTongue.Text = "Mother Tounge is " + (Profile.Profile.PersonalInfo.BasicDetails.MotherTongue ?? string.Empty);

                LblPlace.Text = "Lives in " + (Profile.Profile.PersonalInfo.Location.Place ?? string.Empty);
                LblState.Text = Profile.Profile.PersonalInfo.Location.State ?? string.Empty;
                LblCountry.Text = Profile.Profile.PersonalInfo.Location.Country ?? string.Empty;
                LblCitizenship.Text = (Profile.Profile.PersonalInfo.Location.Citizenship ?? string.Empty) + " citizen";
                LblEatingHabits.Text = Profile.Profile.PersonalInfo.BasicDetails.EatingHabits ?? string.Empty;                

                LblSmokingHabits.Text = (Profile.Profile.PersonalInfo.BasicDetails.SmokingHabits ?? string.Empty) == string.Empty ? "Doesn't Smoke" : Profile.Profile.PersonalInfo.BasicDetails.SmokingHabits;
                LblDrinkingHabits.Text = (Profile.Profile.PersonalInfo.BasicDetails.DrinkingHabits ?? string.Empty) == string.Empty ? "Doesn't Drink" : Profile.Profile.PersonalInfo.BasicDetails.DrinkingHabits;
                LblDrugsHabits.Text = (Profile.Profile.PersonalInfo.BasicDetails.DrugsHabits ?? string.Empty) == string.Empty ? "Doesn't Drug" : Profile.Profile.PersonalInfo.BasicDetails.DrugsHabits;

                //Relegious
                LblAboutRelegious.Text = (gender != "" ? gender == "Male" ? "His" : gender == "Female" ? "Her" : "Person" : "") + " Religious Details";

                LblRelegion.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Religion ?? string.Empty;
                LblCaste.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Caste ?? string.Empty;
                LblSubCaste.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Subcaste ?? string.Empty;
                LblGothram.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Gothram ?? "Request Gothram";
                LbLStar.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Star ?? "Request Star";
                LblDosham.Text = Profile.Profile.PersonalInfo.ReligiousInfo.Papam ?? "Doesn't know dosham details";                
                LblHoroscopeMatches.Text = "50% Horoscope compactible";


            }
            catch (Exception)
            {

            }
        }

        #endregion

        private async void BtnCall_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Choosen the call option", "OK");
        }

        private async void BtnShortList_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Short listed", "OK");
        }

        private async void BtnChat_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Choosen the chat option", "OK");
        }
    }
}