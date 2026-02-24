using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class AddressAutocompleteModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string DisplayLine { get; set; }
    }
}
