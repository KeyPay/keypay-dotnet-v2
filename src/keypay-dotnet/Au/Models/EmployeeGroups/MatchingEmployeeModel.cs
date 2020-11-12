using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeGroups
{
    public class MatchingEmployeeModel
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
    }
}
