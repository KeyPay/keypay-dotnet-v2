using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Other
{
    public class GiroBankBranchModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }
}
