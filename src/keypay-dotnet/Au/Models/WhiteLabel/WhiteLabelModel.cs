using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.WhiteLabel
{
    public class WhiteLabelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
