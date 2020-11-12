using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class BiddingEmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
    }
}
