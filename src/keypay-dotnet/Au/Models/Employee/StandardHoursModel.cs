using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.Employee
{
    public class StandardHoursModel
    {
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
    }
}
