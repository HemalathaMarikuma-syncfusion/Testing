using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Matrimony.ViewModels
{
    public class RegistrationViewModel
    {
        private ObservableCollection<RegistrationModel> Date;
        private ObservableCollection<RegistrationModel> Month;
        private ObservableCollection<RegistrationModel> Year;

        public RegistrationViewModel()
        {
            Days = new ObservableCollection<RegistrationModel>();
            Months = new ObservableCollection<RegistrationModel>();
            Years = new ObservableCollection<RegistrationModel>();

            for (int i = 1; i <= 31; i++)
            {
                Days.Add(new RegistrationModel { Date = i.ToString() });
            }
            for (int j = 1; j <= 12; j++)
            {
                Months.Add(new RegistrationModel { Month = j.ToString() });
            }
            for (int z = 1975; z <= 2005; z++)
            {
                Years.Add(new RegistrationModel { Year = z.ToString() });
            }
        }

        public ObservableCollection<RegistrationModel> Days
        {
            get { return Date; }
            set { Date = value; }
        }

        public ObservableCollection<RegistrationModel> Months
        {
            get { return Month; }
            set { Month = value; }
        }

        public ObservableCollection<RegistrationModel> Years
        {
            get { return Year; }
            set { Year = value; }
        }
    }

    public class RegistrationModel
    {
        public string Date { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
    }

}
