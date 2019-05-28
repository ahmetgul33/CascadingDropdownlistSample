using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownlistSample.Models
{
    public class District
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
    }
}