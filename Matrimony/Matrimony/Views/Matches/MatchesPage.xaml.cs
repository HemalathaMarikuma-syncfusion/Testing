﻿using Matrimony.Models;
using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Matches
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchesPage : ContentPage
    {

        private ObservableCollection<SwipesItem> swipesItems;

        public ObservableCollection<SwipesItem> SwipeViewItems
        {
            get { return swipesItems; }
            set { swipesItems = value; }
        }

        public MatchesPage()
        {
   
            this.BindingContext = this;
            InitializeComponent();

            LoadMatchesList();
        }
        private void LoadMatchesList()
        {
            Dummy_LoadMatchesList();
        }

        public void Dummy_LoadMatchesList()
        {
            App.Profiles = new ObservableCollection<Models.MatchProfile>();

            for (int i = 0; i < 20; i++)
            {
                Models.MatchProfile MatchesDetail = new Models.MatchProfile   { Profile = new Models.Profile() };

                #region GeneralDetails

                MatchesDetail.Profile.PersonalInfo = new PersonalInfo();
                MatchesDetail.Profile.PersonalInfo.BasicDetails = new BasicDetails();
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo = new ReligiousInfo();
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo = new ProfessionalInfo();
                MatchesDetail.Profile.PersonalInfo.Location = new Location();
                MatchesDetail.Profile.PersonalInfo.BasicPreference = new BasicPreference();
                MatchesDetail.Profile.PersonalInfo.FamilyDetails = new FamilyDetails();
                MatchesDetail.Profile.PersonalInfo.LocationPreference = new LocationPreference();
                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence = new PartnerPrefrence();
                MatchesDetail.Profile.PersonalInfo.ProfessionalPreference = new ProfessionalPreference();
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference = new ReligiousPreference();

                MatchesDetail.Profile.PersonalInfo.IsVerified = i % 2 == 0 ? true : false;
                MatchesDetail.Profile.PersonalInfo.MatrimonyID = "N4526114" + (i < 10 ? string.Format("0{0}", i) : i.ToString());
                MatchesDetail.Profile.PersonalInfo.AboutYou = "My son is a software engineer with Master's degree. Currently working in private company in banglore. We come from middle class nuclear family, background with traditional values.";
                MatchesDetail.Profile.PersonalInfo.AboutYourFamily = "Describe about your family";
                MatchesDetail.Profile.PersonalInfo.ViewsAboutYourMarriageLife = "Describe about your dreams in your marriage life";

                #endregion

                #region BasicDetails

                MatchesDetail.Profile.PersonalInfo.BasicDetails.Name = "Lamborghini";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.Age = "28 yrs";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.Height = "154 cm";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.Weight = "56 Kg";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.Gender = "Female";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.BodyType = "Slim";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.Complexion = "Fair";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.MaterialStatus = "Never Married";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.MotherTongue = "Malayalam";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.PhysicalStatus = "Athletic";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.ProfileCreatedBy = "Parents";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.EatingHabits = "Non veg";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.SmokingHabits = "";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.DrinkingHabits = "";
                MatchesDetail.Profile.PersonalInfo.BasicDetails.DrugsHabits = "";

                #endregion

                #region ProfessionalInfo

                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.Degree = "Master Degree";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.AnnualIncome = "800000";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.EducationCategory = "MCA";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.EmployedIn = "Acusis Software Pvt Ltd";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.Institution = "BIT Banglore";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.Occupation = "Software Engineer";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.OccupationInDetail = "Senior Software Engineer";
                MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.Organization = "Acusis Software Pvt Ltd";

                #endregion

                #region ReligiousInfo

                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Caste = "Nair";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Subcaste = "Nair";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Religion = "Hindhu";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Star = "Thiruvonam";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Gothram = "";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Papam = "";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Raasi = "-Nil-";
                MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Zodiac = "-Nil-";

                #endregion

                #region Location

                MatchesDetail.Profile.PersonalInfo.Location.Country = "India";
                MatchesDetail.Profile.PersonalInfo.Location.Citizenship = "Indian";
                MatchesDetail.Profile.PersonalInfo.Location.State = "Kerala";
                MatchesDetail.Profile.PersonalInfo.Location.District = "Kollam";
                MatchesDetail.Profile.PersonalInfo.Location.City = "Kollam";
                MatchesDetail.Profile.PersonalInfo.Location.Place = "Meenambalam";

                #endregion

                #region FamilyDetails

                MatchesDetail.Profile.PersonalInfo.FamilyDetails.AncestralOrigin = "Meenambalam";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.FathersOccupation = "Teacher";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.MothersOccupation = "Home Maker";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.Brothers = "1";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.BrothersMarried = "-Nil-";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.FamilyStatus = "Orthadox";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.FamilyType = "Middle Class";
                MatchesDetail.Profile.PersonalInfo.FamilyDetails.FamilyValues = "-Nil-";

                #endregion

                #region BasicPreference

                MatchesDetail.Profile.PersonalInfo.BasicPreference.Age = "20 - 30";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.DrinkingHabits = "Never Drink";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.DrugsHabits = "Never Drug";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.EatingHabits = "Non Veg";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.Height = "5.2 - 5.4";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.MaterialStatus = "5.2 - 5.4";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.PhysicalStatus = "Slim";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.SmokingHabits = "Non Smoker";
                MatchesDetail.Profile.PersonalInfo.BasicPreference.Weight = "48 - 56";

                #endregion

                #region ReligiousPreference

                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.Caste = "Nair";
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.Dosham = "-Nil-";
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.MotherTongue = "Malayalam";
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.Religion = "Hindhu";
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.Star = "Thiruvonam,Karthika,Punartham";
                MatchesDetail.Profile.PersonalInfo.ReligiousPreference.Subcaste = "Nair";

                #endregion

                #region ProfessionalPreference

                MatchesDetail.Profile.PersonalInfo.ProfessionalPreference.AnnualIncome = "300000 - 600000";
                MatchesDetail.Profile.PersonalInfo.ProfessionalPreference.Education = "Degree";
                MatchesDetail.Profile.PersonalInfo.ProfessionalPreference.Occupation = "Any";

                #endregion

                #region LocationPreference

                MatchesDetail.Profile.PersonalInfo.LocationPreference.AncestralOrigin = "-Nil-";
                MatchesDetail.Profile.PersonalInfo.LocationPreference.Citizenship = "India";
                MatchesDetail.Profile.PersonalInfo.LocationPreference.Country = "India";
                MatchesDetail.Profile.PersonalInfo.LocationPreference.ResidingCity = "Kollam,Thiruvananthapuram";
                MatchesDetail.Profile.PersonalInfo.LocationPreference.ResidingState = "Kollam,Thiruvananthapuram";

                #endregion

                #region PartnerPrefrence

                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence.BasicPreference = MatchesDetail.Profile.PersonalInfo.BasicPreference;
                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence.LocationPreference = MatchesDetail.Profile.PersonalInfo.LocationPreference;
                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence.ProfessionalPreference = MatchesDetail.Profile.PersonalInfo.ProfessionalPreference;
                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence.ReligiousPreference = MatchesDetail.Profile.PersonalInfo.ReligiousPreference;
                MatchesDetail.Profile.PersonalInfo.PartnerPrefrence.WhatWeAreLookingFor = "";

                #endregion

                MatchesDetail.ImageUrl = "https://picsum.photos/350/350";
                MatchesDetail.ProfileID = MatchesDetail.Profile.PersonalInfo.MatrimonyID ?? string.Empty;
                MatchesDetail.Age = MatchesDetail.Profile.PersonalInfo.BasicDetails.Age ?? string.Empty;
                MatchesDetail.Caste = MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Caste ?? string.Empty;
                MatchesDetail.Course = MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.EducationCategory ?? string.Empty;
                MatchesDetail.District = MatchesDetail.Profile.PersonalInfo.Location.District ?? string.Empty;
                MatchesDetail.Location = MatchesDetail.Profile.PersonalInfo.Location.Place ?? string.Empty;
                MatchesDetail.Height = MatchesDetail.Profile.PersonalInfo.BasicDetails.Height ?? string.Empty;
                MatchesDetail.Name = MatchesDetail.Profile.PersonalInfo.BasicDetails.Name ?? string.Empty;
                MatchesDetail.Qualification = MatchesDetail.Profile.PersonalInfo.ProfessionalInfo.Degree ?? string.Empty;
                MatchesDetail.Religion = MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Religion ?? string.Empty;
                MatchesDetail.Star = MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Star ?? string.Empty;
                MatchesDetail.State = MatchesDetail.Profile.PersonalInfo.Location.State ?? string.Empty;
                MatchesDetail.SubCaste = MatchesDetail.Profile.PersonalInfo.ReligiousInfo.Subcaste ?? string.Empty;

                App.Profiles.Add(MatchesDetail);
            }

            ListViewMatches.ItemsSource = App.Profiles;
        }

        private void ListViewMatches_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.MatchProfile Profile = new Models.MatchProfile();
            Profile = ListViewMatches.SelectedItem as Models.MatchProfile;
            Navigation.PushModalAsync(new ProfileDetails(Profile));
        }

        private async void BlockProfile_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Blocked the member", "OK");
        }

        private async void FavoriteProfile_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Favorite member", "OK");
        }

        private async void LikeProfile_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Liked the member", "OK");
        }

        private async void Login_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "Login tapped", "OK");
        }


        private int _lastItemAppearedIdx = 0;
        private bool IsLastDirectionWasUp = false;
        List<Models.MatchProfile> Item = new List<Models.MatchProfile>();
        private void ListViewMatches_ItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {
            try
            {
                if (App.Profiles != null && App.Profiles.Contains(e.Item))
                {
                    if (App.Profiles.Contains(e.Item))
                    {
                        var currentIdx = App.Profiles.IndexOf(e.Item as Models.MatchProfile);
                        if (currentIdx > _lastItemAppearedIdx)
                        {
                            stackMatchTypes.IsVisible = false;
                            IsLastDirectionWasUp = true;
                        }
                        else if(IsLastDirectionWasUp)
                        {
                            IsLastDirectionWasUp = false;
                            stackMatchTypes.IsVisible = true;
                            relativeCompletePage.RaiseChild(stackMatchTypes);
                        }
                        _lastItemAppearedIdx = currentIdx;
                    }
                }

            }
            catch (Exception) { }
        }

        #region Identify InActive State

        public Stopwatch Stopwatch = new Stopwatch();
        public int InActiveTime = 4;
        public bool IsIdealTimerStarted = false;

        public void OnIdealCheckup_Start()
        {
            try
            {
                if (InActiveTime > 0)
                {
                    if (!Stopwatch.IsRunning)
                    {
                        Stopwatch.Start();
                    }

                    if (!IsIdealTimerStarted)
                    {
                        Device.StartTimer(new TimeSpan(0, 0, 1), () =>
                        {
                            IsIdealTimerStarted = true;
                            if (Stopwatch.IsRunning && Stopwatch.Elapsed.Seconds >= InActiveTime)
                            {
                                Device.BeginInvokeOnMainThread(() => { ShowNavigationBar(); });
                                Stopwatch.Restart();
                            }
                            return true;
                        });
                    }
                }
            }
            catch (Exception) { }
        }

        public void OnIdealCheckup_Restart()
        {
            try
            {
                if (Stopwatch.IsRunning && IsIdealTimerStarted)
                {
                    stackNavigationBar.IsVisible = false;
                    Stopwatch.Restart();
                }
            }
            catch (Exception) { }
        }

        public void OnIdealCheckup_Stop()
        {
            if (Stopwatch.IsRunning && IsIdealTimerStarted)
            {
                Stopwatch.Stop();
                IsIdealTimerStarted = false;
            }
        }

        private void ShowNavigationBar()
        {
            stackNavigationBar.IsVisible = true;
            Stopwatch.Restart();
        }

        #endregion


        private async void TapSendInterest_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("", "Interest sent", "OK");
        }

        private async void imageUserGesture_Tapped(object sender, EventArgs e)
        {
            CloseAnimation();
            var img = sender as Image;
            await Navigation.PushModalAsync(new Views.Common.ProfilePhotos() { BindingContext = new PhotosViewModel() { SelectedImage = img.Source } });
        }
        #region SwipeViewGestures

        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                isOpen = value;

                OnPropertyChanged("IsOpen");
            }
        }

        private void BackArrow_Tapped(object sender, EventArgs e)
        {
            if (!IsOpen)
            {
                MainSwipeView.Open(OpenSwipeItem.LeftItems);
                OpenAnimation();
                IsOpen = true;
            }
            else
            {
                CloseAnimation();
                IsOpen = false;
            }
        }

        private async void OpenAnimation()
        {
            //  await relativeCompletePage.ScaleYTo(0.9, 150, Easing.SinOut);
            IsOpen = true;
            await relativeCompletePage.TranslateTo(350, 0, 280, Easing.SinInOut);
            await relativeCompletePage.RotateTo(-15, 280, Easing.SinOut);
        }

        private async void CloseAnimation()
        {
            await relativeCompletePage.TranslateTo(0, 0, 280, Easing.SinOut);
            await relativeCompletePage.RotateTo(0, 280, Easing.SinOut);
            IsOpen = false;
            //   await relativeCompletePage.ScaleYTo(1, 150, Easing.SinOut);
        }
        private void SwipeBackGround_Tapped(object sender, EventArgs e)
        {
            MainSwipeView.Close();
            CloseAnimation();
        }

  
        protected override void OnDisappearing()
        {
            if(IsOpen)
            {
                CloseAnimation();
                IsOpen = false;
            }
        }

        #endregion
    }
}