using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.User
{
    public class SgUserAccountPartnerMetadata
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Int32> PartnerIds { get; set; }
    }
}
