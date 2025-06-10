using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssPayslipModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string PaySchedule { get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public decimal NetPay { get; set; }
        public string PayerName { get; set; }
        public string PayerAbn { get; set; }
        public string PayerBusinessNumber { get; set; }
    }
}
