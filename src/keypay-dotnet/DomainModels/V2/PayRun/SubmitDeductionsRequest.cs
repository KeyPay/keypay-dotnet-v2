using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class SubmitDeductionsRequest 
    {
        public int PayRunId { get; set; }
        public bool ReplaceExisting { get; set; }
        public IdType EmployeeIdType { get; set; }
        public IdType DeductionCategoryIdType { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string, List<SubmitDeductionModel>> Deductions { get; set; }
    }
}