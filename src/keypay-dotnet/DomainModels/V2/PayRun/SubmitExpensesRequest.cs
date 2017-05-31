using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class SubmitExpensesRequest 
    {
        public SubmitExpensesRequest()
        {
            EmployeeIdType = "standard";
            EmployeeExpenseCategoryIdType = "standard";
            LocationIdType = "standard";
        }
        public int PayRunId { get; set; }
        public bool ReplaceExisting { get; set; }
        public string EmployeeIdType { get; set; }
        public string LocationIdType { get; set; }
        public string EmployeeExpenseCategoryIdType { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string, List<ExpenseModel>> Expenses { get; set; }
    }
}