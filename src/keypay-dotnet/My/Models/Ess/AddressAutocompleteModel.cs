using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class AddressAutocompleteModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string DisplayLine { get; set; }
    }
}
