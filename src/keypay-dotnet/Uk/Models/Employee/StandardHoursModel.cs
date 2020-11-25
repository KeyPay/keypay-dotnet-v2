using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class StandardHoursModel
    {
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
    }
}
