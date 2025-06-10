using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.LookupData
{
    public class NameIdPair
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
