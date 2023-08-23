using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class AwardPackage_PutQueryModel
    {
        public string Url { get; set; }
        public int BusinessId { get; set; }
    }
}
