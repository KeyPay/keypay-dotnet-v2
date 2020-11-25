using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Ess
{
    public class NzAddressModel
    {
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
