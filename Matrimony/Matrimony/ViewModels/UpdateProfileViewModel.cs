using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    class UpdateProfileViewModel
    {
        public UpdateProfileViewModel()
        {
            Collections = new ObservableCollection<UpdateProfileModel>();
            Collections.Add(new UpdateProfileModel { Name = "Add your Father's name" });
            Collections.Add(new UpdateProfileModel { Name = "Members Trust Profile with verified information" });
            Collections.Add(new UpdateProfileModel { Name = "Let your matches know your annual income" });
            Collections.Add(new UpdateProfileModel { Name = "Add Star and Rassi - Let matches discover you" });
            Collections.Add(new UpdateProfileModel { Name = "Add your College/Instituion name" });
            Collections.Add(new UpdateProfileModel { Name = "What is your Father's Occupation?" });
            Collections.Add(new UpdateProfileModel { Name = "What is your Mother's Occupation?" });
            Collections.Add(new UpdateProfileModel { Name = "Provide your siblingdetails" });
        }

        private ObservableCollection<UpdateProfileModel> collection;

        public ObservableCollection<UpdateProfileModel> Collections
        {
            get { return collection; }
            set { collection = value; }
        }
    }

    public class UpdateProfileModel
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
    }    

    public class PartnerFilterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Green Dot Image Visibility

        private bool ageAvailable = false;
        private bool subCasteAvailable;
        private bool starAvailable;
        private bool castAvailable;
        private bool religiousAvailable;
        private bool motherTongueAvailable;
        private bool smokeAvailable;
        private bool dhosamAvailable;
        private bool educationAvailable;
        private bool employedAvailable;
        private bool occupationAvailable;
        private bool annualIncomeAvailable;
        private bool countryAvailable;
        private bool residingStateAvialble;
        private bool residingCityAvialable;
        private bool heightAvailable;
        private bool maritalAvailable;
        private bool haveChildrenAvailable;
        private bool physicalAvailable;
        private bool eatingAvailable;
        private bool drinkAvailable;



        public bool AgeAvailable
        {
            get { return ageAvailable; }
            set
            {
                ageAvailable = value;
                NotifyPropertyChanged();
            }
        }        

        public bool HeightAvailable
        {
            get { return heightAvailable; }
            set
            {
                heightAvailable = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool MaritalAvailable
        {
            get { return maritalAvailable; }
            set
            {
                maritalAvailable = value;
                NotifyPropertyChanged();
            }
        }

        public bool HaveChildrenAvailable
        {
            get { return haveChildrenAvailable; }
            set
            {
                haveChildrenAvailable = value;
                NotifyPropertyChanged();
            }
        }

        public bool PhysicalAvailable
        {
            get { return physicalAvailable; }
            set
            {
                physicalAvailable = value;
                NotifyPropertyChanged();
            }
        }

        public bool EatingAvailable
        {
            get { return eatingAvailable; }
            set
            {
                eatingAvailable = value;
                NotifyPropertyChanged();
            }
        }

        public bool DrinkAvailable
        {
            get { return drinkAvailable; }
            set
            {
                drinkAvailable = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool SmokeAvailable
        {
            get { return smokeAvailable; }
            set
            {
                smokeAvailable = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool MotherTongueAvailable
        {
            get { return motherTongueAvailable; }
            set
            {
                motherTongueAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool ReligiousAvailable
        {
            get { return religiousAvailable; }
            set
            {
                religiousAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool CastAvailable
        {
            get { return castAvailable; }
            set
            {
                castAvailable = value;
                NotifyPropertyChanged();
            }
        }        

        public bool SubCasteAvailable
        {
            get { return subCasteAvailable; }
            set
            {
                subCasteAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool StarAvailable
        {
            get { return starAvailable; }
            set
            {
                starAvailable = value;
                NotifyPropertyChanged();
            }
        }
        
        public bool DhosamAvailable
        {
            get { return dhosamAvailable; }
            set
            {
                dhosamAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool EducationAvailable
        {
            get { return educationAvailable; }
            set
            {
                educationAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool EmployedAvailable
        {
            get { return employedAvailable; }
            set
            {
                employedAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool OccupationAvailable
        {
            get { return occupationAvailable; }
            set
            {
                occupationAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool AnnualIncomeAvailable
        {
            get { return annualIncomeAvailable; }
            set
            {
                annualIncomeAvailable = value;
                NotifyPropertyChanged();
            }

        }        

        public bool CountryAvailable
        {
            get { return countryAvailable; }
            set
            {
                countryAvailable = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool ResidingStateAvialble
        {
            get { return residingStateAvialble; }
            set
            {
                residingStateAvialble = value;
                NotifyPropertyChanged();
            }

        }
        
        public bool ResidingCityAvialable
        {
            get { return residingCityAvialable; }
            set
            {
                residingCityAvialable = value;
                NotifyPropertyChanged();
            }

        }

        #endregion      
    }

}
