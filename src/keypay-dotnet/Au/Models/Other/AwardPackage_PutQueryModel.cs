using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class AwardPackage_PutQueryModel
    {
        public string Url { get; set; }
        public int BusinessId { get; set; }
    }
}
