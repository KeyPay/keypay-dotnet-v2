using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SgAddressModel
    {
        public AddressTypeEnum AddressType { get; set; }
        public string AddressLine3 { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string LevelNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string CountryId { get; set; }
        public int? SuburbId { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public bool? IsManualAddress { get; set; }
        public bool? IsOutOfRegion { get; set; }
    }
}
