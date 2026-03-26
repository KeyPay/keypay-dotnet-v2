using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class CreateOrUpdateEmployeeQueryModel
    {
        public string Model { get; set; }
        public EmployeeMatchType MatchType { get; set; }
    }
}
