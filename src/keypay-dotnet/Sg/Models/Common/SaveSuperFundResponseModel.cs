using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class SaveSuperFundResponseModel
    {
        public string ValidationWarning { get; set; }
        public SuperFundModel Result { get; set; }
    }
}
