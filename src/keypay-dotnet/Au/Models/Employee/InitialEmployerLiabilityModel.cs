using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.Employee
{
    public class InitialEmployerLiabilityModel
    {
        public int EmployerLiabilityCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
