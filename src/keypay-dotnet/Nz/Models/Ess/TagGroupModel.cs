using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class TagGroupModel
    {
        public string GroupName { get; set; }
        public IList<String> TagNames { get; set; }
    }
}
