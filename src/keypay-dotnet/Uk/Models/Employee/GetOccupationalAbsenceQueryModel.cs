using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class GetOccupationalAbsenceQueryModel
    {
        public DateTime EarliestStartDate { get; set; }
        public DateTime LatestStartDate { get; set; }
    }
}
