using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SelectListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public SelectListGroup Group { get; set; }
        public bool Disabled { get; set; }
        public bool Selected { get; set; }
    }
}
