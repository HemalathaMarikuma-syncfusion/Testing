using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Matrimony.ViewModels
{
    public class HoroscopeViewModel
    {
        public HoroscopeViewModel()
        {
            AddCountries();
            AddStates();
            AddChartStyle();
            AddLanguages();
        }
        public ObservableCollection<HoroscopeModel> SelectedCountry;
        public ObservableCollection<HoroscopeModel> SelectedState;
        public ObservableCollection<HoroscopeModel> SelectedCity;
        public ObservableCollection<HoroscopeModel> SelectedChartStyle;
        public ObservableCollection<HoroscopeModel> SelectedLanguage;

        public ObservableCollection<HoroscopeModel> Country = new ObservableCollection<HoroscopeModel>();
        public ObservableCollection<HoroscopeModel> State = new ObservableCollection<HoroscopeModel>();
        public ObservableCollection<HoroscopeModel> City = new ObservableCollection<HoroscopeModel>();
        public ObservableCollection<HoroscopeModel> chartStyle = new ObservableCollection<HoroscopeModel>();
        public ObservableCollection<HoroscopeModel> Language = new ObservableCollection<HoroscopeModel>();       
   
        public ObservableCollection<HoroscopeModel> Countries
        {
            get { return Country; }
            set
            {
                Country = value;
            }
        }

        public ObservableCollection<HoroscopeModel> States
        {
            get { return State; }
            set
            {
                State = value;
            }
        }

        public ObservableCollection<HoroscopeModel> Cities
        {
            get { return City; }
            set
            {
                City = value;
            }
        }

        public ObservableCollection<HoroscopeModel> ChartStyle
        {
            get { return chartStyle; }
            set
            {
                chartStyle = value;
            }
        }

        public ObservableCollection<HoroscopeModel> Languages
        {
            get { return Language; }
            set
            {
                Language = value;
            }
        }

        public void AddCountries()
        {
            Countries.Clear();
            Countries.Add(new HoroscopeModel { Name = "India" });
            Countries.Add(new HoroscopeModel { Name = "US" });
            Countries.Add(new HoroscopeModel { Name = "UK" });
            Countries.Add(new HoroscopeModel { Name = "China" });
            Countries.Add(new HoroscopeModel { Name = "Nepal" });
            Countries.Add(new HoroscopeModel { Name = "Others" });

        }

        public void AddStates()
        {
            States.Clear();
            States.Add(new HoroscopeModel { Name = "Tamilnadu" });
            States.Add(new HoroscopeModel { Name = "Kerala" });
            States.Add(new HoroscopeModel { Name = "Andra" });
            States.Add(new HoroscopeModel { Name = "UP" });
            States.Add(new HoroscopeModel { Name = "Maharastra" });
            States.Add(new HoroscopeModel { Name = "Others" });
        }

        public void AddCities()
        {
            if (SelectedState.ToString() == "Tamilnadu")
            {
                Cities.Clear();
                Cities.Add(new HoroscopeModel { Name = "Chennai" });
                Cities.Add(new HoroscopeModel { Name = "Pondy" });
                Cities.Add(new HoroscopeModel { Name = "Nagai" });
                Cities.Add(new HoroscopeModel { Name = "Erode" });
                Cities.Add(new HoroscopeModel { Name = "Namakkal" });
            }
            else if (SelectedState.ToString() == "Kerala")
            {
                Cities.Clear();
                Cities.Add(new HoroscopeModel { Name = "kolugu" });
                Cities.Add(new HoroscopeModel { Name = "udupi" });
                Cities.Add(new HoroscopeModel { Name = "kanga" });
                Cities.Add(new HoroscopeModel { Name = "thiruvandram" });
                Cities.Add(new HoroscopeModel { Name = "kochi" });
            }
            else
            {
                Cities.Add(new HoroscopeModel { Name = "select one state" });
            }

        }

        public void AddChartStyle()
        {
            ChartStyle.Clear();
            ChartStyle.Add(new HoroscopeModel { Name = "South Indian" });
            ChartStyle.Add(new HoroscopeModel { Name = "North Indian" });
            ChartStyle.Add(new HoroscopeModel { Name = "East Indian" });
            ChartStyle.Add(new HoroscopeModel { Name = "Tamil" });
        }

        public void AddLanguages()
        {
            Languages.Clear();
            Languages.Add(new HoroscopeModel { Name = "English" });
            Languages.Add(new HoroscopeModel { Name = "Tamil" });
            Languages.Add(new HoroscopeModel { Name = "Kanandam" });
            Languages.Add(new HoroscopeModel { Name = "Telugu" });
            Languages.Add(new HoroscopeModel { Name = "Malayalam" });
        }
    }

    public class HoroscopeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string Name { get; set; }
    }
}

