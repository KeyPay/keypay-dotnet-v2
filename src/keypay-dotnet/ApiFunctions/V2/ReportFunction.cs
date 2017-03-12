using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPay.DomainModels.V2.PayRun;
using KeyPay.DomainModels.V2.Report;
using KeyPay.Enums;
using Newtonsoft.Json;

namespace KeyPay.ApiFunctions.V2
{
    public class ReportFunction : BaseFunction
    {
        public ReportFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<ActivityReportExportModel> PayRunActivity(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0)
        {
            return ApiRequest<List<ActivityReportExportModel>>(string.Format("/business/{0}/report/payrunactivity?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&payScheduleId={3}&locationId={4}", businessId, fromDate, toDate, payScheduleId, locationId));
        }

        public List<DetailedActivityReportExportModel> DetailedActivity(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int? employingEntityId = 0)
        {
            return ApiRequest<List<DetailedActivityReportExportModel>>(string.Format("/business/{0}/report/detailedactivity?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&payScheduleId={3}&locationId={4}&employingEntityId={5}", businessId, fromDate, toDate, payScheduleId, locationId, employingEntityId));
        }

        public List<SuperAccrualExportModel> SuperContributionsByEmployee(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int? employingEntityId = 0)
        {
            return ApiRequest<List<SuperAccrualExportModel>>(string.Format("/business/{0}/report/supercontributions/byemployee?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&payScheduleId={3}&locationId={4}&employingEntityId={5}", businessId, fromDate, toDate, payScheduleId, locationId, employingEntityId));
        }

        public List<SuperContributionsReportExportModel> SuperContributionsBySuperFund(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int? employingEntityId = 0)
        {
            return ApiRequest<List<SuperContributionsReportExportModel>>(string.Format("/business/{0}/report/supercontributions/bysuperfund?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&payScheduleId={3}&locationId={4}&employingEntityId={5}", businessId, fromDate, toDate, payScheduleId, locationId, employingEntityId));
        }

        public List<DeductionsReportExportModel> Deductions(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int employeeId = 0, int deductionCategoryId = 0, int? employingEntityId = 0)
        {
            return ApiRequest<List<DeductionsReportExportModel>>(string.Format("/business/{0}/report/deductions?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}&employeeId={4}&deductionCategoryId={5}&payScheduleId={6}&employingEntityId={7}", businessId, fromDate, toDate, locationId, employeeId, deductionCategoryId, payScheduleId, employingEntityId));
        }

        public List<PayCategoriesReportExportModel> PayCategories(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int employeeId = 0, int? employingEntityId = 0, bool groupByEarningsLocation = false)
        {
            return ApiRequest<List<PayCategoriesReportExportModel>>(string.Format("/business/{0}/report/paycategories?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}&employeeId={4}&payScheduleId={5}&employingEntityId={6}&groupByEarningsLocation={7}", businessId, fromDate, toDate, locationId, employeeId, payScheduleId, employingEntityId, groupByEarningsLocation));
        }

        public List<PaymentHistoryReportExportModel> PaymentHistory(int businessId, DateTime fromDate, DateTime toDate, int locationId = 0, int employeeId = 0, int? employingEntityId = 0)
        {
            return ApiRequest<List<PaymentHistoryReportExportModel>>(string.Format("/business/{0}/report/paymenthistory?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}&employeeId={4}&employingEntityId={5}", businessId, fromDate, toDate, locationId, employeeId, employingEntityId));
        }

        public List<LeaveBalancesReportExportModel> LeaveBalances(int businessId, int locationId = 0, int leaveTypeId = 0, bool useDefaultLocation = false, int? employingEntityId = 0)
        {
            var groupBy = useDefaultLocation ? LeaveReportDisplay.DefaultLocation : LeaveReportDisplay.AccrualLocation;
            return ApiRequest<List<LeaveBalancesReportExportModel>>(string.Format("/business/{0}/report/leavebalances?locationId={1}&leaveTypeId={2}&groupBy={3}&employingEntityId={4}", businessId, locationId, leaveTypeId, groupBy, employingEntityId));
        }

        public List<BirthdayReportExportModel> Birthday(int businessId, DateTime fromDate, DateTime toDate, int locationId = 0)
        {
            return ApiRequest<List<BirthdayReportExportModel>>(string.Format("/business/{0}/report/birthday?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}", businessId, fromDate, toDate, locationId));
        }

        public List<RosterLiveLeaveAccruals> LeaveBalancesExport(int businessId, int[] payScheduleIds)
        {
            var payScheduleFilter = new StringBuilder();
            if (payScheduleIds != null && payScheduleIds.Any())
            {
                payScheduleFilter.Append("?");
                foreach (var payScheduleId in payScheduleIds)
                {
                    payScheduleFilter.AppendFormat("payScheduleIds={0}&", payScheduleId);
                }
            }
            var result = ApiJsonRequest(string.Format("/business/{0}/report/leavebalancesexport{1}", businessId, payScheduleFilter));
            return JsonConvert.DeserializeObject<List<RosterLiveLeaveAccruals>>(result);
        }

        public List<PayrollExemptReportExportModel> PayrollExempt(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0, int? employingEntityId = 0, string state = null)
        {
            return ApiRequest<List<PayrollExemptReportExportModel>>(string.Format("/business/{0}/report/payrollexempt?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}&payscheduleid={4}&employingEntityId={5}&state={6}", businessId, fromDate, toDate, locationId, payScheduleId, employingEntityId, state));
        }

        public List<MLCSuperReportExportModel> MLCSuperExport(int businessId, int[] payScheduleIds)
        {
            var payScheduleFilter = new StringBuilder();
            if (payScheduleIds != null && payScheduleIds.Any())
            {
                payScheduleFilter.Append("?");
                foreach (var payScheduleId in payScheduleIds)
                {
                    payScheduleFilter.AppendFormat("payScheduleIds={0}&", payScheduleId);
                }
            }
            return ApiRequest<List<MLCSuperReportExportModel>>(string.Format("/business/{0}/report/mlcsuper{1}", businessId, payScheduleFilter));
        }

        public List<WorkersCompReportGridModel> WorkersComp(int businessId, DateTime fromDate, DateTime toDate, int locationId = 0)
        {
            var url = string.Format("/business/{0}/report/workerscomp?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}", businessId, fromDate, toDate, locationId);
            return ApiRequest<List<WorkersCompReportGridModel>>(url);
        }

        public List<LeaveHistoryReportGroupModel> LeaveHistory(int businessId, DateTime fromDate, DateTime toDate, int payScheduleId = 0, int locationId = 0)
        {
            var url = string.Format("/business/{0}/report/leavehistory?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&payScheduleId={3}&locationId={4}", businessId, fromDate, toDate, payScheduleId, locationId);
            return ApiRequest<List<LeaveHistoryReportGroupModel>>(url);
        }

        public List<EmployeeDetailsReportField> EmployeeDetailsFields(int businessId)
        {
            var url = string.Format("/business/{0}/report/employeedetails/fields", businessId);
            return ApiRequest<List<EmployeeDetailsReportField>>(url);
        }

        public List<dynamic> EmployeeDetails(int businessId, List<string> selectedFields, int locationId = 0, int? employingEntityId = null, bool includeActive = true, bool includeInactive = true)
        {
            var combinedSelectedFields = "";
            if (selectedFields != null && selectedFields.Any())
            {
                var builder = new StringBuilder();
                foreach (var selectedField in selectedFields)
                {
                    builder.AppendFormat("selectedColumns={0}&", selectedField);
                }
                combinedSelectedFields = builder.ToString();
            }
            var url = string.Format("/business/{0}/report/employeedetails?{1}locationId={2}&includeActive={3}&includeInactive={4}", businessId, combinedSelectedFields, locationId, includeActive, includeInactive);
            if (employingEntityId != null)
            {
                url = string.Format("{0}&employingEntityId={1}", url, employingEntityId);
            }
            var data = ApiJsonRequest<List<dynamic>>(url);
            return data;
        }

        public List<PayrollTaxReportExportModel> PayrollTax(int businessId, DateTime fromDate, DateTime toDate, int locationId = 0, int? employingEntityId = null)
        {
            var url = string.Format("/business/{0}/report/payrolltax?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}{4}", businessId, fromDate, toDate, locationId, employingEntityId.HasValue ? "&employingEntityId=" + employingEntityId.Value : "");
            return ApiJsonRequest<List<PayrollTaxReportExportModel>>(url);
        }

        public List<PaygReportExportModel> PaygWithholding(int businessId, DateTime fromDate, DateTime toDate, int locationId = 0, int? employingEntityId = null, string state = null)
        {
            var url = string.Format("/business/{0}/report/payg?fromDate={1:yyyy-MM-dd}&toDate={2:yyyy-MM-dd}&locationId={3}&state={4}{5}", businessId, fromDate, toDate, locationId, state, employingEntityId.HasValue ? "&employingEntityId=" + employingEntityId.Value : "");
            return ApiJsonRequest<List<PaygReportExportModel>>(url);
        }

        public List<LeaveLiabilityReportExportModel> LeaveLiability(int businessId, DateTime? asAtDate = null, int locationId = 0, int leaveTypeId = 0, bool includeApprovedLeave = true)
        {
            var url = string.Format("/business/{0}/report/leaveliability?locationId={1}&asAtDate={2:yyyy-MM-dd}&leaveTypeId={3}&includeApprovedLeave={4}", businessId, locationId, asAtDate, leaveTypeId, includeApprovedLeave);
            return ApiRequest<List<LeaveLiabilityReportExportModel>>(url);
        }
    }
}