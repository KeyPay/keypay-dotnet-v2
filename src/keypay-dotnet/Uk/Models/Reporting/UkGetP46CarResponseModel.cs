using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkGetP46CarResponseModel
    {
        public IEnumerable<UkP46CarModel> P46Cars { get; set; }
    }
}
