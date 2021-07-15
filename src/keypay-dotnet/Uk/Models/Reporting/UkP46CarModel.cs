using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP46CarModel
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public int BusinessId { get; set; }
        public string EmployeeName { get; set; }
        public bool IsIgnored { get; set; }
        public bool IsReplacement { get; set; }
        public string CarMakeAndModel { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string ChangeTypeDescription { get; set; }
    }
}
