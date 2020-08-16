using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Constant
{
    public class Page
    {
        public PageName Name { get; set; }
    }
    public enum PageName
    {
        #region Authentication

        Login,
        FPAuthentication,

        #endregion

        #region Registration

        Registration,

        #endregion

        #region Update Profile details

        UpdateProfile,
        ReligiousInformation,
        ProfessionalInformation,
        PartnerFilter,
        Location,
        FamilyDetails,
        EditContact,
        BasicDetail,
        AddHoroscope,

        #endregion

        #region Preference

        BasicPrefrence,
        LocationPrefernce,
        ProfessionalPreference,
        ReligiousPreference,

        #endregion

        #region Profile

        Profile,
        ProfileDetails,

        #endregion

        #region Mailbox

            Mailbox,

        #endregion

        #region Matches

        Matches,

        #endregion

        #region Payments

        Payments,

        #endregion

        #region Profile Photo

        ProfilePhoto

        #endregion

    };
}
