using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class P45ViewModel
    {
        public DateTime? EmployeeEndDate { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string P45Url { get; set; }
    }
}
