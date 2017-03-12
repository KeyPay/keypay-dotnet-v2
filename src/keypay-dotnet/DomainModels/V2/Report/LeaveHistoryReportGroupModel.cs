using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Report
{
    public class LeaveHistoryReportGroupModel
    {
        public LeaveHistoryReportGroupModel()
        {
            LeaveHistoryDetails = new List<LeaveHistoryReportDetailModel>();
        }
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LeaveCategoryType { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public List<LeaveHistoryReportDetailModel> LeaveHistoryDetails { get; set; }
    }
}