using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class P60CertificateApiModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BusinessId { get; set; }
        public Char Status { get; set; }
        public DateTime? NotificationDate { get; set; }
        public DateTime? DateGenerated { get; set; }
        public string EmployeeName { get; set; }
        public decimal PayThisEmployment { get; set; }
        public decimal TaxThisEmployment { get; set; }
        public decimal TotalPay { get; set; }
        public decimal TotalTax { get; set; }
        public string TaxCode { get; set; }
        public decimal TotalStatutoryPay { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal PostgraduateLoan { get; set; }
        public string PreviewUrl { get; set; }
        public bool IsOutdated { get; set; }
        public string DownloadUrl { get; set; }
    }
}
