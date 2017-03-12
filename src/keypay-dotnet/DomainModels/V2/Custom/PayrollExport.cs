using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;

namespace KeyPay.DomainModels.V2.Custom
{
    public class PayrollExport
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeAgreementId { get; set; }
        public int PeriodId { get; set; }
        public bool RecommendedLoadings { get; set; }
        public int Timesheets { get; set; }
        public int TimesheetsTimeApproved { get; set; }
        public int TimesheetsPayApproved { get; set; }
        public int PaycycleRules { get; set; }
        public int PaycycleRulesApproved { get; set; }
        public bool Exported { get; set; }
        public int ExportId { get; set; }
        public bool Paid { get; set; }
        public decimal TimeTotal { get; set; }
        public decimal CostTotal { get; set; }
        public int EmployeeAgreementHistoryId { get; set; }
        public int? Creator { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public EmployeeAgreement EmployeeAgreement { get; set; }
        public List<TimesheetPayReturnArray> PaycycleReturnArray { get; set; }
        public List<TimesheetArray> TimesheetArray { get; set; }
    }
}