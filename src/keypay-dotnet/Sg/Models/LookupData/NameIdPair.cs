using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.LookupData
{
    public class NameIdPair
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
