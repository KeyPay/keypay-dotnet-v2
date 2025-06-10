using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeePayRateSchedule
{
    public class PayRateScheduleModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Rate { get; set; }
        public string RateUnit { get; set; }
        public DateTime CommencementDate { get; set; }
    }
}
