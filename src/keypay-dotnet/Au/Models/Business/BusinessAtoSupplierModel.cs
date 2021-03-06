using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class BusinessAtoSupplierModel
    {
        public int Id { get; set; }
        public string Abn { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string ContactName { get; set; }
        public string SignatoryName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Country { get; set; }
        public string Branch { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AtoSupplierRole Role { get; set; }
        public string TaxAgentNumber { get; set; }
        public string IntermediaryAbn { get; set; }
        public string IntermediaryContactName { get; set; }
        public string IntermediaryContactEmail { get; set; }
        public string IntermediaryContactPhone { get; set; }
    }
}
