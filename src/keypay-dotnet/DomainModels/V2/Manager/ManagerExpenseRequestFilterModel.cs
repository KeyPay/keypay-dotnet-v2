using System;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerExpenseRequestFilterModel
    {
        public EmployeeExpenseRequestStatus? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? ExpenseCategoryId { get; set; }
        public EmployeeExpenseRequestGroupBy? GroupBy { get; set; }
        public int CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }

    public enum EmployeeExpenseRequestGroupBy
    {
        Employee,
        ExpenseCategory
    }
}
