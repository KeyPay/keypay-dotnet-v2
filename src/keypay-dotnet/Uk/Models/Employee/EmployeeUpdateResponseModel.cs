using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class EmployeeUpdateResponseModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string DetailedStatus { get; set; }
    }
}
