using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Authentication
{
    public class SingleSignOnRequestModel
    {
        public int? BusinessId { get; set; }
        public string UserName { get; set; }
        public string Url { get; set; }
        public NavigationDisplayEnum Navigation { get; set; }
        public string HostName { get; set; }
    }
}
