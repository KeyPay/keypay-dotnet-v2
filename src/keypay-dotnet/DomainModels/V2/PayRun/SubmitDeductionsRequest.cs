using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class SubmitDeductionsRequest 
    {
        public SubmitDeductionsRequest()
        {
            EmployeeIdType = "standard";
            DeductionCategoryIdType = "standard";
        }
        public int PayRunId { get; set; }
        public bool ReplaceExisting { get; set; }
        public string EmployeeIdType { get; set; }
        public string DeductionCategoryIdType { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string, List<SubmitDeductionModel>> Deductions { get; set; }
    }
}