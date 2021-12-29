using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class MyBusinessStatutorySettingsModel
    {
        public string Itn { get; set; }
        public string ENumber { get; set; }
        public string EpfNumber { get; set; }
        public string SocsoNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public HrdfStatus? HrdfStatus { get; set; }
        public string LhdnmBranch { get; set; }
        public string SerialNo { get; set; }
        public string NameOfOfficer { get; set; }
        public string OfficerDesignation { get; set; }
        public string OfficerIdNumber { get; set; }
        public string OfficerPhoneNumber { get; set; }
        public string OfficerEmail { get; set; }
        public bool? EisEnabled { get; set; }
        public string ZakatNumber { get; set; }
    }
}
