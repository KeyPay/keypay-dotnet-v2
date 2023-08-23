using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class AwardPackage_PutQueryModel
    {
        public string Url { get; set; }
        public int BusinessId { get; set; }
    }
}
