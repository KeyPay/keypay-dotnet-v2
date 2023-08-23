using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class NumericNullableSelectListItem
    {
        public int? Value { get; set; }
        public string Text { get; set; }
    }
}
