using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class InconsistentNIRecordModel
    {
        public int EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int NationalInsuranceRecordId { get; set; }
        public int BusinessId { get; set; }
        public string TaxCode { get; set; }
        public string NiRecordUrl { get; set; }
    }
}
