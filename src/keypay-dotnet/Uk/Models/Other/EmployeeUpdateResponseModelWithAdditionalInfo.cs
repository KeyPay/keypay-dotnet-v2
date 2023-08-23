using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class EmployeeUpdateResponseModelWithAdditionalInfo
    {
        public int? ResidentialSuburbId { get; set; }
        public int? PostalSuburbId { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public string DetailedStatus { get; set; }
    }
}
