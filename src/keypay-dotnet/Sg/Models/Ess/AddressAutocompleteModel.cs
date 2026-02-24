using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class AddressAutocompleteModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string DisplayLine { get; set; }
    }
}
