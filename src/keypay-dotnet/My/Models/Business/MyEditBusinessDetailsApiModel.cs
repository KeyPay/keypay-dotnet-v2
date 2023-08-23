using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class MyEditBusinessDetailsApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public DayOfWeek EndOfWeek { get; set; }
        public string Crn { get; set; }
        public bool RegistrationNumberValidationBypassed { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string LevelNumber { get; set; }
        public int StandardDaysPerWeek { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormulaForCalculatingOrdinaryRateOfPayEnum FormulaForCalculatingOrdinaryRateOfPay { get; set; }
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
