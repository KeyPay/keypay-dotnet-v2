using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class CreateOrUpdateEmployeeQueryModel
    {
        public string Model { get; set; }
        public EmployeeMatchType MatchType { get; set; }
    }
}
