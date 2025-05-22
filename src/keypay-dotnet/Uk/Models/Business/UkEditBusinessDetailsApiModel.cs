using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkEditBusinessDetailsApiModel
    {
        public string Chrn { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int BusinessId { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Postcode { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public decimal? StandardHoursPerDay { get; set; }
        public int EndOfWeek { get; set; }
        public string ExternalId { get; set; }
        public bool IsSmsNotificationEnabled { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService? Source { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}
