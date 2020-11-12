using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PaySchedule
{
    public class PayRunWarningModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
