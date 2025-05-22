using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class NumericNullableSelectListItem
    {
        public int? Value { get; set; }
        public string Text { get; set; }
    }
}
