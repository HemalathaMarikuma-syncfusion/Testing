using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Matrimony.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace Matrimony.Views.Registration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddHoroscope : ContentPage
	{       
        HoroscopeViewModel HoroscopeViewModel = new HoroscopeViewModel();
        public AddHoroscope()
        {
            InitializeComponent();
            this.BindingContext = HoroscopeViewModel;
        }
        
        private void DateOfBirth_Tapped(object sender, EventArgs e)
        {
            datePicker.IsVisible = true;
        }

        private void ListView_Tapped(object sender, EventArgs e)
        {
            PopupListView.IsVisible = false;
        }

        private void ListItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (HoroscopeViewModel.Countries.Count > 0)
            {
                CountryLabel.Text = (e.Item as HoroscopeModel).Name.ToString();
            }
            else if (HoroscopeViewModel.States.Count > 0)
            {
                StateLabel.Text = (e.Item as HoroscopeModel).Name.ToString();
            }
            else if (HoroscopeViewModel.Cities.Count > 0)
            {
                CityOfBirthLabel.Text = (e.Item as HoroscopeModel).Name.ToString();
            }
            else if (HoroscopeViewModel.ChartStyle.Count > 0)
            {
                ChartStyleLabel.Text = (e.Item as HoroscopeModel).Name.ToString();
            }
            else if (HoroscopeViewModel.Languages.Count > 0)
            {
                LanguageLabel.Text = (e.Item as HoroscopeModel).Name.ToString();
            }
            PopupListView.IsVisible = false;
        }

        private void CountryPopupListView_Tapped(object sender, EventArgs e)
        {
            PopupListView.IsVisible = false;
        }

        private void CountryofBirth_Tapped(object sender, EventArgs e)
        {

            HoroscopeViewModel.States.Clear();
            HoroscopeViewModel.Cities.Clear();
            HoroscopeViewModel.ChartStyle.Clear();
            HoroscopeViewModel.Languages.Clear();
            HoroscopeViewModel.AddCountries();
            Listview.ItemsSource = HoroscopeViewModel.Countries;
            PopupListView.IsVisible = true;
        }

        private void StateOfBirth_Tapped(object sender, EventArgs e)
        {
            HoroscopeViewModel.Countries.Clear();
            HoroscopeViewModel.Cities.Clear();
            HoroscopeViewModel.ChartStyle.Clear();
            HoroscopeViewModel.Languages.Clear();
            HoroscopeViewModel.AddStates();
            Listview.ItemsSource = HoroscopeViewModel.States;
            PopupListView.IsVisible = true;
        }

        private void CityOfBirthLabel_Tapped(object sender, EventArgs e)
        {

            HoroscopeViewModel.Countries.Clear();
            HoroscopeViewModel.ChartStyle.Clear();
            HoroscopeViewModel.Languages.Clear();
            HoroscopeViewModel.AddCities();
            Listview.ItemsSource = HoroscopeViewModel.Cities;
            HoroscopeViewModel.States.Clear();
            PopupListView.IsVisible = true;
        }

        private void ChartStyleLabel_Tapped(object sender, EventArgs e)
        {
            HoroscopeViewModel.States.Clear();
            HoroscopeViewModel.Countries.Clear();
            HoroscopeViewModel.Cities.Clear();
            HoroscopeViewModel.Languages.Clear();
            HoroscopeViewModel.AddChartStyle();
            Listview.ItemsSource = HoroscopeViewModel.ChartStyle;
            PopupListView.IsVisible = true;
        }

        private void LanguageLabel_Tapped(object sender, EventArgs e)
        {
            HoroscopeViewModel.States.Clear();
            HoroscopeViewModel.Countries.Clear();
            HoroscopeViewModel.Cities.Clear();
            HoroscopeViewModel.ChartStyle.Clear();
            HoroscopeViewModel.AddLanguages();
            Listview.ItemsSource = HoroscopeViewModel.Languages;
            PopupListView.IsVisible = true;
        }

        private async void UploadHoroscope_Tapped(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Not supported", "Your device does not currenly support this functionality", "O.K");
                return;
            }
            var mediaoptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaoptions);
            if (HoroscopeImage == null)
            {
                await DisplayAlert("Error", "Could not get the image, please try again.", "O.K");
                return;
            }
            HoroscopeImage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());

        }

    }

    internal class ObservableCollection<T>
    {
        private List<string> lists;

        public ObservableCollection()
        {
        }

        public ObservableCollection(List<string> lists)
        {
            this.lists = lists;
        }
    }

}