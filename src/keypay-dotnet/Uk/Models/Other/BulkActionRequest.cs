using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Other
{
    public class BulkActionRequest
    {
        public List<Int32> DestinationBusinessIds { get; set; }
        public List<String> ItemsToCopy { get; set; }
    }
}
