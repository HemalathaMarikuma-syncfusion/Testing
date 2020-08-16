using Matrimony.ViewModels;
using Matrimony.Views.Registration.Preferences;
using Plugin.Media;
using Plugin.Media.Abstractions;
//using Plugin.Media;
//using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Registration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
	public partial class UpdateProfileDetailsPage : ContentPage
	{
        public int ProfileCompletion = 78;
        public UpdateProfileDetailsPage ()
		{
			InitializeComponent ();
            
            this.BindingContext = profileViewModel;
        }

        UpdateProfileViewModel profileViewModel = new UpdateProfileViewModel();

        private async void BackArrowTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistationPage());
        }

        private async void EditContact_Tapped(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new EditContact());
        }

        //Button click to open the gallery in android
        private async void AddPhotos_Tapped(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if(!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Not supported", "Your device does not currenly support this functionality", "O.K");
                return;
            }
            var mediaoptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaoptions);
            if (mainimage == null)
            {
                await DisplayAlert("Error", "Could not get the image, please try again.", "O.K");
                return;
            }
            mainimage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());

          
        }

        private async void AddHoroscope_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddHoroscope());
        }

        private async void Fewwords_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("About", "A few words about");
            if (result != null && Aboutlabel.Text.ToString() != result.ToString())
            {
                Aboutlabel.Text = result;
                Aboutlabel.TextColor = Color.Black;
            }   
            else if(result == null)
            {
               await DisplayAlert("About","No changes", "O.K");
            }
        }

        private async void BasicDetails_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BasicDetail());
        }

        private async void BodTypeLabel_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Body Type", "Cancel", null, "Average", "Slim", "Fit");
            if (action != "Cancel" && action != null)
            {
                BodTypeLabel.TextColor = Color.Black;
                BodTypeLabel.Text = action;
            }
                
        }

        private async void Complexion_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Complexion", "Cancel", null, "Very Fair", "Fair", "Wheatish", "Wheatish Brown", "Dark");
            if (action != "Cancel" && action != null)
            {
                ComplexionLabel.Text = action;
                ComplexionLabel.TextColor = Color.Black;
            }
        }

        private async void EatingHabits_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("EatingHabits", "Cancel", null, "Veg", "Non-Veg", "Vegan");
            if (action != "Cancel" && action != null)
            {
                EatingHabitsLabel.Text = action;
                EatingHabitsLabel.TextColor = Color.Black;
            }
        }

        private async void DrinkingHabitsLabel_Tapped_(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Drinking Habits", "Cancel", null, "Yes", "N.O", "Ocassionally");
            if (action != "Cancel" && action != null)
            {
                DrinkingHabitsLabel.Text = action;
                DrinkingHabitsLabel.TextColor = Color.Black;
            }
        }

        private async void SmokingHabits_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Smoking Habits", "Cancel", null, "Yes", "N.O", "Ocassionally");
            if (action != "Cancel" && action != null)
            {
                SmokingHabitsLabel.Text = action;
                SmokingHabitsLabel.TextColor = Color.Black;
            }
        }

        private async void GothraLabel_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Gotra", "Type your Gotra");
            if (result != null && Aboutlabel.Text.ToString() != result.ToString())
            {
                GothraLabel.Text = result;
                GothraLabel.TextColor = Color.Black;
            }
            else if (result == null)
            {
                await DisplayAlert("About", "No changes", "O.K");
            }                   
        }

        private async void ZodiacLabel_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Zodiac", "Cancel", null, "Aries", "Tarus", "Gemini","Cancer","Others");
            if (action != "Cancel" && action != null)
            {
                ZodiacLabel.Text = action;
                ZodiacLabel.TextColor = Color.Black;
            }
        }

        private  async void StarLabel_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Star", "Cancel", null, "Magam", "Ruthra", "Mesham", "Rishabam", "Others");
            if (action != "Cancel" && action != null)
            {
                StarLabel.Text = action;
                StarLabel.TextColor = Color.Black;
            }
        }

        private async void RaasiLabel_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Raasi", "Cancel", null, "Aries", "Tarus", "Gemini", "Cancer", "Others");
            if (action != "Cancel" && action != null)
            {
                RaasiLabel.Text = action;
                RaasiLabel.TextColor = Color.Black;
            }
        }

        private async void DoshamLabel_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Dhosam", "Cancel", null, "Yes", "No");
            if (action != "Cancel" && action != null)
            {
                DoshamLabel.Text = action;
                DoshamLabel.TextColor = Color.Black;
            }
        }

        private async void ReligiousInformation_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReligiousInformation());
        }

        private async void Professional_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfessionalInformation());
        }

        private async void Location_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Location());
        }

        private async void FamilyDetails_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FamilyDetails());
        }

        private async void FamilyValues_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Family Value", "Cancel", null, "Orthodex", "Traditiona", "Moderate", "Liberal");
            if (action != "Cancel" && action != null)
            {
                FamilyValuesLabel.Text = action;
                FamilyValuesLabel.TextColor = Color.Black;
            }
        }

        private async void FamilyType_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Family Type", "Cancel", null, "Joint", "Nuclears", "Others");
            if (action != "Cancel" && action != null)
            {
                FamilyTypeLabel.Text = action;
                FamilyTypeLabel.TextColor = Color.Black;
            }
        }

        private async void FamilyStatus_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Family Status", "Cancel", null, "Middle Class", "Upper-Middle Class", "High Class","Rich");
            if (action != "Cancel" && action != null)
            {
                FamilyStatusLabel.Text = action;
                FamilyStatusLabel.TextColor = Color.Black;
            }
        }

        private async void FathersOccupation_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Father's Occupation", "Cancel", null, "Employeed", "BusinessMan", "Professional", "Retired","Not Employed","Passed Away");
            if (action != "Cancel" && action != null)
            {
                FathersOccupationLabel.Text = action;
                FathersOccupationLabel.TextColor = Color.Black;
            }
        }

        private async void MothersOccupation_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Mother's Occupation", "Cancel", null, "Employeed", "BusinessMan", "Professional", "Retired", "Not Employed", "Passed Away");
            if (action != "Cancel" && action != null)
            {
                MothersOccupationLabel.Text = action;
                MothersOccupationLabel.TextColor = Color.Black;
            }
        }

        private async void Brothers_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Numbers of Brothers", "Cancel", null, "0", "1", "2", "3", "4", "4+");
            if (action != "Cancel" && action != null)
            {
                BrothersLabel.Text = action;
                BrothersLabel.TextColor = Color.Black;
            }
        }

        private async void BrothersMarried_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Brother Married", "Cancel", null, "Yes","No");
            if (action != "Cancel" && action != null)
            {
                BrothersMarriedLabel.Text = action;
                BrothersMarriedLabel.TextColor = Color.Black;
            }
        }

        private async void Sisters_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Numbers of Sisters", "Cancel", null, "0", "1", "2", "3", "4", "4+");
            if (action != "Cancel" && action != null)
            {
                SistersLabel.Text = action;
                SistersLabel.TextColor = Color.Black;
            }
        }

        private async void SistersMarried_Tapped(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Sister Married", "Cancel", null, "Yes", "No");
            if (action != "Cancel" && action != null)
            {
                SistersMarriedLabel.Text = action;
                SistersMarriedLabel.TextColor = Color.Black;
            }
        }

        private async void Ancestor_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Add Ancestor Origin", "Enter Ancestral Origin");
            if (result != null && AncestorLabel.Text.ToString() != result.ToString())
            {
                AncestorLabel.Text = result;
                AncestorLabel.TextColor = Color.Black;
            }
            else if (result == null)
            {
                await DisplayAlert("About", "No changes", "O.K");
            }
        }

        private async void Aboutourfamily_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("About our family", "Enter few words about family");
            if (result != null && AboutourfamilyLabel.Text.ToString() != result.ToString())
            {
                AboutourfamilyLabel.Text = result;
                AboutourfamilyLabel.TextColor = Color.Black;
            }
            else if (result == null)
            {
                await DisplayAlert("About", "No changes", "O.K");
            }
        }

        private async void HobbiesandInterest_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Hobbies and Interest", "Enter few words about Hobbies");
            if (result != null && HobbiesandInterestLabel.Text.ToString() != result.ToString())
            {
                HobbiesandInterestLabel.Text = result;
                HobbiesandInterestLabel.TextColor = Color.Black;
            }
            else if (result == null)
            {
                await DisplayAlert("About", "No changes", "O.K");
            }
        }

        private async void PartnerRefrence_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PartnerFilter());
        }

        private async  void BasicPreferences_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BasicPrefrences());
        }

        private async  void ReligiousPreferences_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReligiousPreferences());
        }

        private async  void ProfessionalPreferences_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfessionalPreferences());
        }

        private async void LocationPreferences_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LocationPrefernce());
        }

        private async void Whatlooking_Tapped(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("WHAT WE ARE lOOKING FOR", "Enter few words about partner");
            if (result != null && WhatlookingLabel.Text.ToString() != result.ToString())
            {
                WhatlookingLabel.Text = result;
                WhatlookingLabel.TextColor = Color.Black;
            }
            else if (result == null)
            {
                await DisplayAlert("About", "No changes", "O.K");
            }
        }   
    }
}