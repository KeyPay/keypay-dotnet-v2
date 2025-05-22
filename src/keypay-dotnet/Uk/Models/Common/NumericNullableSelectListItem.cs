using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class NumericNullableSelectListItem
    {
        public int? Value { get; set; }
        public string Text { get; set; }
    }
}
