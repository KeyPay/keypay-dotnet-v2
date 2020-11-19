using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class InitialEmployerLiabilityModel
    {
        public int EmployerLiabilityCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
