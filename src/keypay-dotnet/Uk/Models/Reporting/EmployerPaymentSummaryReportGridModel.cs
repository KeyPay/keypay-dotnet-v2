using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class EmployerPaymentSummaryReportGridModel
    {
        public int Id { get; set; }
        public Guid? RtiRequestTransactionId { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal SmpRecovered { get; set; }
        public decimal NicCompensationOnSmp { get; set; }
        public decimal SncpRecovered { get; set; }
        public decimal NicCompensationOnSncp { get; set; }
        public decimal SppRecovered { get; set; }
        public decimal NicCompensationOnSpp { get; set; }
        public decimal SpbpRecovered { get; set; }
        public decimal NicCompensationOnSpbp { get; set; }
        public decimal SapRecovered { get; set; }
        public decimal NicCompensationOnSap { get; set; }
        public decimal ShppRecovered { get; set; }
        public decimal NicCompensationOnShpp { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateResponseReceived { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EpsSubmissionStatusEnum? Status { get; set; }
        public bool CanSubmitEps { get; set; }
        public List<String> Errors { get; set; }
        public decimal CisDeductionsSuffered { get; set; }
        public decimal ApprenticeshipLevy { get; set; }
        public DateTime? NoPaymentDateStart { get; set; }
        public DateTime? NoPaymentDateEnd { get; set; }
        public DateTime? PeriodOfInactivityStart { get; set; }
        public DateTime? PeriodOfInactivityEnd { get; set; }
        public DateTime? PayeSchemeCeasedDate { get; set; }
    }
}
