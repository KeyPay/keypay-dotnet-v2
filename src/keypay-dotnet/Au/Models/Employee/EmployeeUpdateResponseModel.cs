using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class EmployeeUpdateResponseModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string DetailedStatus { get; set; }
    }
}
