using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class AwardPackage_PutQueryModel
    {
        public string Url { get; set; }
        public int BusinessId { get; set; }
    }
}
