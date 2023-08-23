using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class UpdateStatusEventQueryModel
    {
        public ExternalService? Service { get; set; }
    }
}
