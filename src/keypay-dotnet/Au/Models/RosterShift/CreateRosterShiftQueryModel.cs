using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.RosterShift
{
    public class CreateRosterShiftQueryModel
    {
        public bool Publish { get; set; }
    }
}
