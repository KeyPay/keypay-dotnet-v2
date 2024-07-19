using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class AuDashboardModel
    {
        public AuFeaturesModel Features { get; set; }
        public AuEssRosterShiftModel NextShift { get; set; }
        public EssCurrentShiftModel CurrentShift { get; set; }
        public EssPayslipModel LatestPayslip { get; set; }
        public IList<LeaveBalanceModel> LeaveBalances { get; set; }
        public List<TitleViewModel> Titles { get; set; }
        public List<EssWorkTypeModel> WorkTypes { get; set; }
        public List<EssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ClassificationSelectModel> Classifications { get; set; }
        public IList<EssLeaveCategoryModel> LeaveCategories { get; set; }
        public EssSatisfactionSurvey CurrentWeekSatisfactionSurvey { get; set; }
        public EssCurrentTimesheetsModel Timesheets { get; set; }
        public DateTime TimesheetEntryPeriodEnd { get; set; }
        public IList<ExpenseCategoryResponseModel> ExpenseCategories { get; set; }
        public IList<JournalServiceTaxCode> TaxCodes { get; set; }
        public EssCurrentExpensesModel Expenses { get; set; }
        public int PendingShiftCount { get; set; }
        public int ProposedSwapCount { get; set; }
        public int PendingLeaveCount { get; set; }
        public int DocumentsRequiringAcknowledgementCount { get; set; }
        public string Region { get; set; }
        public int BiddableShiftCount { get; set; }
        public bool IsTerminated { get; set; }
        public string GoogleMapsApiKey { get; set; }
        public DateTime? StartDate { get; set; }
        public StandardHoursModel StandardHours { get; set; }
        public int NotAcceptedShiftsCount { get; set; }
    }
}
