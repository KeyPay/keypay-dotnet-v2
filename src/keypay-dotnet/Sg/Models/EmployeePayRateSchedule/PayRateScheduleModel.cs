using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeePayRateSchedule
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
