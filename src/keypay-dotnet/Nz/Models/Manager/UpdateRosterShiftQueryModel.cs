using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class UpdateRosterShiftQueryModel
    {
        public bool Publish { get; set; }
        public bool? ClearBreaks { get; set; }
    }
}
