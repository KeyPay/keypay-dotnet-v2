using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class AuEditBusinessDetailsApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek EndOfWeek { get; set; }
        public string Abn { get; set; }
        public bool IsForeignEntity { get; set; }
        public string ForeignEntityCountry { get; set; }
        public int BusinessId { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Postcode { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public decimal? StandardHoursPerDay { get; set; }
        public string ExternalId { get; set; }
        public bool IsSmsNotificationEnabled { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService? Source { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}
