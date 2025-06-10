using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class BiddingEmployee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoneNumber { get; set; }
    }
}
