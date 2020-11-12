using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LookupData
{
    public class NameIdPair
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
