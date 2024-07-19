using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.RosterShift
{
    public class UpdateRosterShiftQueryModel
    {
        public bool Publish { get; set; }
        public bool? ClearBreaks { get; set; }
    }
}
