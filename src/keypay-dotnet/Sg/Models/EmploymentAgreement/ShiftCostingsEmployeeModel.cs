using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmploymentAgreement
{
    public class ShiftCostingsEmployeeModel
    {
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public decimal? StandardHoursPerWeek { get; set; }
        public decimal? StandardHoursPerDay { get; set; }
        public IList<String> Tags { get; set; }
    }
}
