using System.Collections.Generic;
using System.Text;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using KeyPay.DomainModels.V2.Manager;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerExpenseFunction : BaseFunction
    {
        public ManagerExpenseFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public PagedResultModel<ManagerExpenseRequestModel> List(int businessId, ManagerExpenseRequestFilterModel filter)
        {
            var queryString = new StringBuilder("?");
            if (filter.Status.HasValue) queryString.Append($"Status={filter.Status.ToString()}&");
            if (filter.FromDate.HasValue) queryString.Append($"FromDate={filter.FromDate.Value.ToString("yyyy-MM-dd")}&");
            if (filter.ToDate.HasValue) queryString.Append($"ToDate={filter.ToDate.Value.ToString("yyyy-MM-dd")}&");
            if (filter.ExpenseCategoryId.HasValue) queryString.Append($"ExpenseCategoryId={filter.ExpenseCategoryId}&");
            if (filter.LocationId.HasValue) queryString.Append($"LocationId={filter.LocationId}&");
            if (filter.EmployeeId.HasValue) queryString.Append($"EmployeeId={filter.EmployeeId}&");
            queryString.Append($"CurrentPage={filter.CurrentPage}&");
            if (filter.PageSize.HasValue) queryString.Append($"EmployeeId={filter.PageSize}&");

            return ApiRequest<PagedResultModel<ManagerExpenseRequestModel>>($"/business/{businessId}/manager/expense{queryString}");
        }

        public List<ExpenseCategoryResponseModel> Categories(int businessId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/business/{businessId}/manager/expense/categories");
        }

        public List<ManagerExpenseEmployeeModel> Employees(int businessId)
        {
            return ApiRequest<List<ManagerExpenseEmployeeModel>>($"/business/{businessId}/manager/expense/employees");
        }

        public List<LocationModel> Locations(int businessId)
        {
            return ApiRequest<List<LocationModel>>($"/business/{businessId}/manager/expense/locations");
        }

        public List<ManagerEmployeeGroup> EmployeeGroups(int businessId)
        {
            return ApiRequest<List<ManagerEmployeeGroup>>($"/business/{businessId}/manager/expense/employeegroups");
        }
        
        public List<ExpenseTaxCode> TaxCodes(int businessId)
        {
            return ApiRequest<List<ExpenseTaxCode>>($"/business/{businessId}/manager/expense/taxcodes");
        }

        public List<ExpenseReferenceData> Reference(int businessId, int employeeId)
        {
            return ApiRequest<List<ExpenseReferenceData>>($"/business/{businessId}/manager/expense/{employeeId}/reference");
        }

        public ManagerExpenseRequestModel Get(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}");
        }

        public ManagerExpenseRequestModel Create(int businessId, int employeeId, ManagerExpenseRequestEditModel expenseRequestModel)
        {
            return ApiRequest<ManagerExpenseRequestModel, ManagerExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense", expenseRequestModel, Method.POST);
        }

        public ManagerExpenseRequestModel Update(int businessId, int employeeId, int expenseRequestId, ManagerExpenseRequestEditModel expenseRequestModel)
        {
            return ApiRequest<ManagerExpenseRequestModel, ManagerExpenseRequestEditModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", expenseRequestModel, Method.PUT);
        }

        public ManagerExpenseRequestModel Approve(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/approve", Method.POST);
        }

        public ManagerExpenseRequestModel Decline(int businessId, int employeeId, int expenseRequestId, string reason)
        {
            return ApiRequest<ManagerExpenseRequestModel, DeclineReason>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/decline", new DeclineReason { Reason = reason }, Method.POST);
        }

        public void Delete(int businessId, int employeeId, int expenseRequestId)
        {
            ApiRequest<ManagerExpenseRequestModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}", Method.DELETE);
        }

        public DocumentFile Attachment(int businessId, int employeeId, int expenseRequestId)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment");
        }

        public AttachmentModel UploadAttachment(int businessId, int employeeId, int expenseRequestId, FileUploadModel document)
        {
            var result = ApiFileRequest<AttachmentModel>($"/business/{businessId}/manager/{employeeId}/expense/{expenseRequestId}/attachment", document, Method.PUT);
            return result;
        }
    }
}