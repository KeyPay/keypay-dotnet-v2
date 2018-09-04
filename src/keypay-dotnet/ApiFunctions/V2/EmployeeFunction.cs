using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeeFunction : BaseFunction
    {
        public EmployeeFunction(ApiRequestExecutor api) : base(api)
        {
            LeaveAllowance = new EmployeeLeaveAllowanceFunction(api);
            OpeningBalances = new OpeningBalancesFunction(api);
            Notes = new NotesFunction(api);
            LeaveBalances = new LeaveBalanceFunction(api);
            Documents = new EmployeeDocumentFunction(api);
            PayRuns = new EmployeePayRunFunction(api);
            LeaveRequests = new LeaveRequestFunction(api);
            StandardHours = new StandardHoursFunction(api);
        }

        public EmployeeLeaveAllowanceFunction LeaveAllowance { get; set; }
        public LeaveBalanceFunction LeaveBalances { get; set; }
        public LeaveRequestFunction LeaveRequests { get; set; }
        public OpeningBalancesFunction OpeningBalances { get; set; }
        public NotesFunction Notes { get; set; }
        public EmployeeDocumentFunction Documents { get; set; }
        public EmployeePayRunFunction PayRuns { get; set; }
        public StandardHoursFunction StandardHours { get; set; }

        public IList<EmployeeModel> List(int businessId, int? skip = null)
        {
            var url = string.Format("/business/{0}/employee", businessId);
            if (skip.HasValue)
                url += "?$skip=" + skip.Value;
            return ApiRequest<List<EmployeeModel>>(url);
        }

        public EmployeeModel Get(int businessId, int employeeId)
        {
            return ApiRequest<EmployeeModel>("/business/" + businessId + "/employee/" + employeeId);
        }

        public CreateEmployeeResponse Create(int businessId, EmployeeModel model)
        {
            return ApiRequest<CreateEmployeeResponse, EmployeeModel>("/business/" + businessId + "/employee/unstructured", model, Method.POST);
        }

        public EmployeeModel Update(int businessId, EmployeeModel model)
        {
            return ApiRequest<EmployeeModel, EmployeeModel>("/business/" + businessId + "/employee/unstructured/" + model.Id, model, Method.PUT);
        }

        public EmployeeModel GetByExternalReferenceId(int businessId, string externalReferenceId, string source)
        {
            return ApiRequest<EmployeeModel>(string.Format("/business/{0}/employee/unstructured/?externalreferenceid={1}&source={2}", businessId, externalReferenceId, source));
        }

        public EmployeeModel GetByExternalId(int businessId, string externalId)
        {
            return ApiRequest<EmployeeModel>(string.Format("/business/{0}/employee/unstructured/?externalId={1}", businessId, externalId));
        }

        public IList<EmployeeModel> Query(int businessId, string oDataFilterExpression, int? payScheduleId = null, int? locationId = null, int page = 1, int pageSize = 100)
        {
            var payScheduleFilter = payScheduleId.HasValue
                ? $"&payScheduleId={payScheduleId.Value}"
                : "";
            var locationFilter= locationId.HasValue
                ? $"&locationId={locationId.Value}"
                : "";
            var oDataFilter = string.IsNullOrEmpty(oDataFilterExpression) ? string.Empty : $"&$filter={oDataFilterExpression}";
            return ApiRequest<List<EmployeeModel>>(
                $"/business/{businessId}/employee/unstructured/?$skip={page-1*pageSize}&top={pageSize}{payScheduleFilter}{locationFilter}{oDataFilter}");
        }
    }
}