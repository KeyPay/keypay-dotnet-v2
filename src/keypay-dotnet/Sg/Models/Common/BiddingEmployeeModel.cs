using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class BiddingEmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
    }
}
