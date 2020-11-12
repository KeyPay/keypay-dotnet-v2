using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class ProfileImageMetadata
    {
        public string ContentType { get; set; }
        public string Extension { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
}
