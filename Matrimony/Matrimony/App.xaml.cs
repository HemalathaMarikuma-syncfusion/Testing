using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Matrimony.Views;
using Matrimony.Models;
using System.Collections.Generic;
using Matrimony.ViewModels;
using System.IO;
using System.Collections.ObjectModel;
using Matrimony.Models.Constant;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Matrimony
{
    public partial class App : Application
    {
        public static Models.MatchProfile SelectedMatcheProfile { get; set; }
        public static Models.Profile ProfileDetails { get; set; }
        public static Models.MatchProfile MatchesDetails { get; set; }
        public static ObservableCollection<Models.MatchProfile> MatchingProfiles { get; set; }
        public static ObservableCollection<Models.MatchProfile> Profiles { get; set; }

        #region App.XAML.cs

        public App()
        {
            InitializeComponent();


            MainPage = new Views.Authentication.Login();// Profile(); MainPage(); Matches(); ProfileDetails();
            //FPAuthentication(); RegistationPage(); UpdateProfileDetailsPage();
        }

        public void NavigatePage(Models.Constant.Page page, MatchProfile matche = null)
        {
            switch(page.Name)
            {
                case PageName.Login:
                    MainPage = new NavigationPage(new Views.Authentication.Login());
                    break;
                case PageName.FPAuthentication:
                    MainPage = new NavigationPage(new Views.FPAuthentication());
                    break;
                case PageName.Registration:
                    MainPage = new NavigationPage(new Views.Registration.RegistationPage());
                    break;
                case PageName.UpdateProfile:
                    MainPage = new NavigationPage(new Views.Registration.UpdateProfileDetailsPage());
                    break;
                case PageName.ReligiousInformation:
                    MainPage = new NavigationPage(new Views.Registration.ReligiousInformation());
                    break;
                case PageName.ProfessionalInformation:
                    MainPage = new NavigationPage(new Views.Registration.ProfessionalInformation());
                    break;
                case PageName.PartnerFilter:
                    MainPage = new NavigationPage(new Views.Registration.PartnerFilter());
                    break;
                case PageName.Location:
                    MainPage = new NavigationPage(new Views.Registration.Location());
                    break;
                case PageName.FamilyDetails:
                    MainPage = new NavigationPage(new Views.Registration.FamilyDetails());
                    break;
                case PageName.EditContact:
                    MainPage = new NavigationPage(new Views.Registration.EditContact());
                    break;
                case PageName.BasicDetail:
                    MainPage = new NavigationPage(new Views.Registration.BasicDetail());
                    break;
                case PageName.AddHoroscope:
                    MainPage = new NavigationPage(new Views.Registration.AddHoroscope());
                    break;
                case PageName.BasicPrefrence:
                    MainPage = new NavigationPage(new Views.Registration.Preferences.BasicPrefrences());
                    break;
                case PageName.LocationPrefernce:
                    MainPage = new NavigationPage(new Views.Registration.Preferences.LocationPrefernce());
                    break;
                case PageName.ProfessionalPreference:
                    MainPage = new NavigationPage(new Views.Registration.Preferences.ProfessionalPreferences());
                    break;
                case PageName.ReligiousPreference:
                    MainPage = new NavigationPage(new Views.Registration.Preferences.ReligiousPreferences());
                    break;
                case PageName.Profile:
                    MainPage = new NavigationPage(new Views.Profile());
                    break;
                case PageName.ProfileDetails:
                    MainPage = new NavigationPage(new Views.ProfileDetails(matche));
                    break;
                case PageName.Matches:
                    MainPage = new NavigationPage(new Views.Matches.MatchesPage());
                    break;
                case PageName.Mailbox:
                    MainPage = new NavigationPage(new Views.MailBox.MailBoxPage());
                    break;
                case PageName.Payments:
                    MainPage = new NavigationPage(new Views.Payments.PaymentsPage());
                    break;

            }            
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion

        #region Dummy Data

        public static void Dummy_LoadMatchesList()
        {
            ObservableCollection<Models.MatchProfile> ListMatches = new ObservableCollection<Models.MatchProfile>();

            for (int i = 0; i < 100; i++)
            {
                Models.MatchProfile MatchesDetail = new Models.MatchProfile();
                MatchesDetail.Profile = new Models.Profile();

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

                ListMatches.Add(MatchesDetail);
            }

            MatchingProfiles = ListMatches;
                /*
                Models.Matches Matches = new Models.Matches();
                Matches = MatchesDetails;
                Matches.ProfileID = "100" + (i < 10 ? string.Format("0{0}", i) : i.ToString());
                if (i % 2 == 0)
                {
                    Matches.Profile.PersonalInfo.IsVerified = true;
                }
                else
                {
                    Matches.Profile.PersonalInfo.IsVerified = false;
                }
                */

            }
                    
        public static void Dummy_Matches()
        {
            MatchesDetails = new Models.MatchProfile()
            {
                Profile = ProfileDetails,

                ImageUrl = "https://picsum.photos/350/350",
                Age = ProfileDetails.PersonalInfo.BasicDetails.Age ?? string.Empty,
                Caste = ProfileDetails.PersonalInfo.ReligiousInfo.Caste ?? string.Empty,
                Course = ProfileDetails.PersonalInfo.ProfessionalInfo.EducationCategory ?? string.Empty,
                District = ProfileDetails.PersonalInfo.Location.District ?? string.Empty,
                Location = ProfileDetails.PersonalInfo.Location.Place ?? string.Empty,
                Height = ProfileDetails.PersonalInfo.BasicDetails.Height ?? string.Empty,
                Name = ProfileDetails.PersonalInfo.BasicDetails.Name ?? string.Empty,
                Qualification = ProfileDetails.PersonalInfo.ProfessionalInfo.Degree ?? string.Empty,
                Religion = ProfileDetails.PersonalInfo.ReligiousInfo.Religion ?? string.Empty,
                Star = ProfileDetails.PersonalInfo.ReligiousInfo.Star ?? string.Empty,
                State = ProfileDetails.PersonalInfo.Location.State ?? string.Empty,
                SubCaste = ProfileDetails.PersonalInfo.ReligiousInfo.Subcaste ?? string.Empty
            };
        }

        public static void Dummy_Profile()
        {

            #region GeneralDetails

                Models.Profile ProfileDetails = new Models.Profile();
                ProfileDetails.PersonalInfo = new PersonalInfo();
                ProfileDetails.PersonalInfo.BasicDetails = new BasicDetails();
                ProfileDetails.PersonalInfo.ReligiousInfo = new ReligiousInfo();
                ProfileDetails.PersonalInfo.ProfessionalInfo = new ProfessionalInfo();
                ProfileDetails.PersonalInfo.Location = new Location();
                ProfileDetails.PersonalInfo.BasicPreference = new BasicPreference();
                ProfileDetails.PersonalInfo.FamilyDetails = new FamilyDetails();
                ProfileDetails.PersonalInfo.LocationPreference = new LocationPreference();
                ProfileDetails.PersonalInfo.PartnerPrefrence = new PartnerPrefrence();
                ProfileDetails.PersonalInfo.ProfessionalPreference = new ProfessionalPreference();
                ProfileDetails.PersonalInfo.ReligiousPreference = new ReligiousPreference();

                ProfileDetails.PersonalInfo.MatrimonyID = "N4526114";
                ProfileDetails.PersonalInfo.AboutYou = "My son is a software engineer with Master's degree. Currently working in private company in banglore. We come from middle class nuclear family, background with traditional values.";
                ProfileDetails.PersonalInfo.AboutYourFamily = "Describe about your family";
                ProfileDetails.PersonalInfo.ViewsAboutYourMarriageLife = "Describe about your dreams in your marriage life";

            #endregion

            #region BasicDetails

            ProfileDetails.PersonalInfo.BasicDetails.Name = "Lamborghini";
            ProfileDetails.PersonalInfo.BasicDetails.Age = "28 yrs";
            ProfileDetails.PersonalInfo.BasicDetails.Height = "154 cm";
            ProfileDetails.PersonalInfo.BasicDetails.Weight = "56 Kg";
            ProfileDetails.PersonalInfo.BasicDetails.Gender = "Female";
            ProfileDetails.PersonalInfo.BasicDetails.BodyType = "Slim";
            ProfileDetails.PersonalInfo.BasicDetails.Complexion = "Fair";                        
            ProfileDetails.PersonalInfo.BasicDetails.MaterialStatus = "Never Married";
            ProfileDetails.PersonalInfo.BasicDetails.MotherTongue = "Malayalam";
            ProfileDetails.PersonalInfo.BasicDetails.PhysicalStatus = "Athletic";
            ProfileDetails.PersonalInfo.BasicDetails.ProfileCreatedBy = "Parents";            
            ProfileDetails.PersonalInfo.BasicDetails.EatingHabits = "Non veg";
            ProfileDetails.PersonalInfo.BasicDetails.SmokingHabits = "";
            ProfileDetails.PersonalInfo.BasicDetails.DrinkingHabits = "";
            ProfileDetails.PersonalInfo.BasicDetails.DrugsHabits = "";

            #endregion

            #region ProfessionalInfo

            ProfileDetails.PersonalInfo.ProfessionalInfo.Degree = "Master Degree";
            ProfileDetails.PersonalInfo.ProfessionalInfo.AnnualIncome = "800000";
            ProfileDetails.PersonalInfo.ProfessionalInfo.EducationCategory = "MCA";
            ProfileDetails.PersonalInfo.ProfessionalInfo.EmployedIn = "Acusis Software Pvt Ltd";
            ProfileDetails.PersonalInfo.ProfessionalInfo.Institution = "BIT Banglore";
            ProfileDetails.PersonalInfo.ProfessionalInfo.Occupation = "Software Engineer";
            ProfileDetails.PersonalInfo.ProfessionalInfo.OccupationInDetail = "Senior Software Engineer";
            ProfileDetails.PersonalInfo.ProfessionalInfo.Organization = "Acusis Software Pvt Ltd";

            #endregion

            #region ReligiousInfo

            ProfileDetails.PersonalInfo.ReligiousInfo.Caste = "Nair";
            ProfileDetails.PersonalInfo.ReligiousInfo.Subcaste = "Nair";
            ProfileDetails.PersonalInfo.ReligiousInfo.Religion = "Hindhu";
            ProfileDetails.PersonalInfo.ReligiousInfo.Star = "Thiruvonam";            
            ProfileDetails.PersonalInfo.ReligiousInfo.Gothram = "";
            ProfileDetails.PersonalInfo.ReligiousInfo.Papam = "";
            ProfileDetails.PersonalInfo.ReligiousInfo.Raasi = "-Nil-";
            ProfileDetails.PersonalInfo.ReligiousInfo.Zodiac = "-Nil-";

            #endregion

            #region Location

            ProfileDetails.PersonalInfo.Location.Country = "India";
            ProfileDetails.PersonalInfo.Location.Citizenship = "Indian";
            ProfileDetails.PersonalInfo.Location.State = "Kerala";
            ProfileDetails.PersonalInfo.Location.District = "Kollam";
            ProfileDetails.PersonalInfo.Location.City = "Kollam";
            ProfileDetails.PersonalInfo.Location.Place = "Meenambalam";

            #endregion

            #region FamilyDetails

            ProfileDetails.PersonalInfo.FamilyDetails.AncestralOrigin = "Meenambalam";
            ProfileDetails.PersonalInfo.FamilyDetails.FathersOccupation = "Teacher";
            ProfileDetails.PersonalInfo.FamilyDetails.MothersOccupation = "Home Maker";
            ProfileDetails.PersonalInfo.FamilyDetails.Brothers = "1";
            ProfileDetails.PersonalInfo.FamilyDetails.BrothersMarried = "-Nil-";
            ProfileDetails.PersonalInfo.FamilyDetails.FamilyStatus = "Orthadox";
            ProfileDetails.PersonalInfo.FamilyDetails.FamilyType = "Middle Class";
            ProfileDetails.PersonalInfo.FamilyDetails.FamilyValues = "-Nil-";

            #endregion

            #region BasicPreference

            ProfileDetails.PersonalInfo.BasicPreference.Age = "20 - 30";
            ProfileDetails.PersonalInfo.BasicPreference.DrinkingHabits = "Never Drink";
            ProfileDetails.PersonalInfo.BasicPreference.DrugsHabits = "Never Drug";
            ProfileDetails.PersonalInfo.BasicPreference.EatingHabits = "Non Veg";
            ProfileDetails.PersonalInfo.BasicPreference.Height = "5.2 - 5.4";
            ProfileDetails.PersonalInfo.BasicPreference.MaterialStatus = "5.2 - 5.4";
            ProfileDetails.PersonalInfo.BasicPreference.PhysicalStatus = "Slim";
            ProfileDetails.PersonalInfo.BasicPreference.SmokingHabits = "Non Smoker";
            ProfileDetails.PersonalInfo.BasicPreference.Weight = "48 - 56";

            #endregion

            #region ReligiousPreference

            ProfileDetails.PersonalInfo.ReligiousPreference.Caste = "Nair";
            ProfileDetails.PersonalInfo.ReligiousPreference.Dosham = "-Nil-";
            ProfileDetails.PersonalInfo.ReligiousPreference.MotherTongue = "Malayalam";
            ProfileDetails.PersonalInfo.ReligiousPreference.Religion = "Hindhu";
            ProfileDetails.PersonalInfo.ReligiousPreference.Star = "Thiruvonam,Karthika,Punartham";
            ProfileDetails.PersonalInfo.ReligiousPreference.Subcaste = "Nair";

            #endregion

            #region ProfessionalPreference

            ProfileDetails.PersonalInfo.ProfessionalPreference.AnnualIncome = "300000 - 600000";
            ProfileDetails.PersonalInfo.ProfessionalPreference.Education = "Degree";
            ProfileDetails.PersonalInfo.ProfessionalPreference.Occupation = "Any";

            #endregion

            #region LocationPreference

            ProfileDetails.PersonalInfo.LocationPreference.AncestralOrigin = "-Nil-";
            ProfileDetails.PersonalInfo.LocationPreference.Citizenship = "India";
            ProfileDetails.PersonalInfo.LocationPreference.Country = "India";
            ProfileDetails.PersonalInfo.LocationPreference.ResidingCity = "Kollam,Thiruvananthapuram";
            ProfileDetails.PersonalInfo.LocationPreference.ResidingState = "Kollam,Thiruvananthapuram";

            #endregion

            #region PartnerPrefrence

            ProfileDetails.PersonalInfo.PartnerPrefrence.BasicPreference = ProfileDetails.PersonalInfo.BasicPreference;
            ProfileDetails.PersonalInfo.PartnerPrefrence.LocationPreference = ProfileDetails.PersonalInfo.LocationPreference;
            ProfileDetails.PersonalInfo.PartnerPrefrence.ProfessionalPreference = ProfileDetails.PersonalInfo.ProfessionalPreference;
            ProfileDetails.PersonalInfo.PartnerPrefrence.ReligiousPreference = ProfileDetails.PersonalInfo.ReligiousPreference;
            ProfileDetails.PersonalInfo.PartnerPrefrence.WhatWeAreLookingFor = "";

            #endregion

            DataManager manager = new DataManager();
            var backingFile = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, @"Matrimony\MTR.dat");            
            List<Models.Profile> profiles = new List<Models.Profile>();
            profiles.Add(ProfileDetails);
            manager.WriteData(backingFile, profiles);

        }

        #endregion
    }
}
