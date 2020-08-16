using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class MatchProfile
    {
        public Profile Profile { get; set; }
        public string ProfileID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Qualification { get; set; }
        public string Course { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string SubCaste { get; set; }
        public string Star { get; set; }
        public string Location { get; set; }
        public string District { get; set; }
        public string State { get; set; }
    }
}
