using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkAddressModel
    {
        public int? CityId { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string CountryId { get; set; }
        public bool? IsManualAddress { get; set; }
        public bool? IsOutOfRegion { get; set; }
    }
}
