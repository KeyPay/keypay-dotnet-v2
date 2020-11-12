using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class SwapShiftModel
    {
        public int RosterShiftId { get; set; }
        public int FromEmployeeId { get; set; }
        public int ToEmployeeId { get; set; }
        public string Note { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? CreatedByUserId { get; set; }
        public string Token { get; set; }
    }
}
