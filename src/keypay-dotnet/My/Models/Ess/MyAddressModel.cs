using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyAddressModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
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
