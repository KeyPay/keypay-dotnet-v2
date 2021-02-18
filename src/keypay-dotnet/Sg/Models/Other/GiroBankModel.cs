using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class GiroBankModel
    {
        public int Id { get; set; }
        public string Swift { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
