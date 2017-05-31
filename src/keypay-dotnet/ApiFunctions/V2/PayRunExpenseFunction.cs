using KeyPay.DomainModels.V2.PayRun;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRunExpenseFunction : BaseFunction
    {
        public PayRunExpenseFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public ExpensesResponse List(int businessId, int payRunId)
        {
            return ApiRequest<ExpensesResponse>("/business/" + businessId + "/payrun/" + payRunId + "/employeeexpenses");
        }

        public ExpenseModel Submit(int businessId, SubmitExpensesRequest expenses)
        {
            return ApiRequest<ExpenseModel, SubmitExpensesRequest>("/business/" + businessId + "/payrun/" + expenses.PayRunId + "/employeeexpenses", expenses, Method.POST);
        }

    }
}