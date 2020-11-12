using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class ListLeaveRequestsQueryModel
    {
        public bool ShowOtherEmployees { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
