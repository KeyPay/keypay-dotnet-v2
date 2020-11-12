using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class DeviceTokenModel
    {
        public string Token { get; set; }
        public MobilePlatform Platform { get; set; }
    }
}
