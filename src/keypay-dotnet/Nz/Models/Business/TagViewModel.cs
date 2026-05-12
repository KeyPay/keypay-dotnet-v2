using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int? AwardId { get; set; }
        public string AwardName { get; set; }
    }
}
