using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Unavailability
{
    public class ListUnavailabilitiesQueryModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? DefaultLocationId { get; set; }
    }
}
