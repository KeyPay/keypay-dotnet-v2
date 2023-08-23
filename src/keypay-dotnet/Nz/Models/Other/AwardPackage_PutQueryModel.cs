using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class AwardPackage_PutQueryModel
    {
        public string Url { get; set; }
        public int BusinessId { get; set; }
    }
}
