using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Manager
{
    public class BiddingEmployee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoneNumber { get; set; }
    }
}
