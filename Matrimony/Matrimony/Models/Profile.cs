using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class Profile
    {
        public PersonalInfo PersonalInfo { get; set; }
        public PartnerPrefrence PartnerPrefrence { get; set; }
    }

    #region Personal Information

    public class PersonalInfo
    {
        public bool IsVerified { get; set; }
        public string MatrimonyID { get; set; }
        public string AboutYou { get; set; }
        public string AboutYourFamily { get; set; }
        public string ViewsAboutYourMarriageLife { get; set; }
        public Dictionary<string,string> HobbyAndInterests { get; set; }

        public BasicDetails BasicDetails { get; set; }
        public ReligiousInfo ReligiousInfo { get; set; }
        public ProfessionalInfo ProfessionalInfo { get; set; }
        public Location Location { get; set; }
        public FamilyDetails FamilyDetails { get; set; }
        public PartnerPrefrence PartnerPrefrence { get; set; }
        public BasicPreference BasicPreference { get; set; }
        public ReligiousPreference ReligiousPreference { get; set; }
        public ProfessionalPreference ProfessionalPreference { get; set; }
        public LocationPreference LocationPreference { get; set; }
    }

    public class BasicDetails
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string MaterialStatus { get; set; }
        public string MotherTongue { get; set; }
        public string PhysicalStatus { get; set; }
        public string BodyType { get; set; }
        public string Complexion { get; set; }
        public string ProfileCreatedBy { get; set; }
        public string EatingHabits { get; set; }
        public string DrinkingHabits { get; set; }
        public string SmokingHabits { get; set; }
        public string DrugsHabits { get; set; }
        public Dictionary<string,string> AdditionalInfo { get; set; }
    }

    public class ReligiousInfo
    {
        public string Religion { get; set; }
        public string Caste { get; set; }            
        public string Subcaste { get; set; }
        public string Gothram { get; set; }            
        public string Zodiac { get; set; }
        public string Star { get; set; }            
        public string Raasi { get; set; }
        public string Papam { get; set; }
        public Dictionary<string, string> AdditionalInfo { get; set; }
    }

    public class ProfessionalInfo
    {
        public string Degree { get; set; }
        public string EducationCategory { get; set; }
        public string Institution { get; set; }
        public string Occupation { get; set; }
        public string OccupationInDetail { get; set; }
        public string Organization { get; set; }
        public string EmployedIn { get; set; }
        public string AnnualIncome { get; set; }
        public Dictionary<string,string> AdditionalInfo { get; set; }
    }    

    public class Location
    {
        public string Place { get; set; }
        public string Citizenship { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string City { get; set; }
    }

    public class FamilyDetails
    {
        public string FamilyValues { get; set; }
        public string FamilyType { get; set; }
        public string FamilyStatus { get; set; }
        public string FathersOccupation { get; set; }
        public string MothersOccupation { get; set; }
        public string Brothers { get; set; }
        public string BrothersMarried { get; set; }
        public string AncestralOrigin { get; set; }
    }

    #endregion Personal Information

    #region Partner Prefrence

    public class PartnerPrefrence
    {
        public string WhatWeAreLookingFor  { get; set; }
        public BasicPreference BasicPreference { get; set; }
        public ReligiousPreference ReligiousPreference { get; set; }
        public ProfessionalPreference ProfessionalPreference { get; set; }
        public LocationPreference LocationPreference { get; set; }
    }

    public class BasicPreference
    {
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string MaterialStatus { get; set; }
        public string PhysicalStatus { get; set; }
        public string EatingHabits { get; set; }
        public string SmokingHabits { get; set; }
        public string DrinkingHabits { get; set; }
        public string DrugsHabits { get; set; }
    }

    public class ReligiousPreference
    {
        public string MotherTongue { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string Subcaste { get; set; }
        public string Star { get; set; }
        public string Dosham { get; set; }
    }

    public class ProfessionalPreference
    {
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string AnnualIncome { get; set; }
    }

    public class LocationPreference
    {
        public string Citizenship { get; set; }
        public string AncestralOrigin { get; set; }
        public string Country { get; set; }
        public string ResidingState { get; set; }
        public string ResidingCity { get; set; }
    }

    #endregion Partner Prefrence

}
