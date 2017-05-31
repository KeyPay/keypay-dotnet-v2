using System;
using System.Collections.Generic;
using KeyPay.DomainModels.V2.PayRun;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PayRunFunction : BaseFunction
    {
        public PayRunFunction(ApiRequestExecutor api) : base(api)
        {
            Totals = new PayRunTotalFunction(api);
            LeaveAccrued = new LeaveAccruedFunction(api);
            PaySlip = new PaySlipFunction(api);
            EarningsLines = new EarningsLineFunction(api);
            Details = new PayRunDetailsFunction(api);
            Deductions = new PayRunDeductionFunction(api);
            Expenses = new PayRunExpenseFunction(api);
            PaygAdjustments = new PaygAdjustmentsFunction(api);
            SuperAdjustments = new SuperAdjustmentsFunction(api);
        }

        public PayRunTotalFunction Totals { get; set; }
        public LeaveAccruedFunction LeaveAccrued { get; set; }
        public PaySlipFunction PaySlip { get; set; }
        public EarningsLineFunction EarningsLines { get; set; }
        public PayRunDetailsFunction Details { get; set; }
        public PayRunDeductionFunction Deductions { get; set; }
        public PayRunExpenseFunction Expenses { get; set; }
        public PaygAdjustmentsFunction PaygAdjustments { get; set; }
        public SuperAdjustmentsFunction SuperAdjustments { get; set; }

        public IList<PayRunModel> List(int businessId)
        {
            return ApiRequest<List<PayRunModel>>("/business/" + businessId + "/payrun");
        }

        public PayRunModel GetById(int businessId, int payRunId)
        {
            return ApiRequest<PayRunModel>("/business/" + businessId + "/payrun/" + payRunId);
        }

        public PayRunModel Create(int businessId, PayRunModel model)
        {
            return ApiRequest<PayRunModel, PayRunModel>("/business/" + businessId + "/payrun", model, Method.POST);
        }

        public void Finalise(int businessId, int payRunId, DateTime? datePaid = null)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + payRunId + "/finalise",
                           new {payRunId, datePaid }, Method.POST);
            
        }

        public void Unlock(int businessId, int payRunId, string comments)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + payRunId + "/unlock",
                           new { payRunId, comments}, Method.POST);

        }

        public void Delete(int businessId, int payRunId)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + payRunId, Method.DELETE);
        }


        public void Terminate(int businessId, int payRunId, int employeeId)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + payRunId + "/terminate", new { employeeId }, Method.POST);
        }

        public IList<PayRunModel> GetByPaySchedule(int businessId, int payScheduleId, int records = 20)
        {
            return ApiRequest<List<PayRunModel>>(string.Format("/business/{0}/payrun/?$top={1}&$filter=PayCycle/Id eq {2}&$orderby=DatePaid desc", businessId, records, payScheduleId));
        }

        public void Recalculate(int businessId, int payRunId)
        {
            ApiRequest("/business/" + businessId + "/payrun/" + payRunId + "/recalculate", new object(), Method.POST);
        }

        public string AbaFile(int businessId, int payRunId, int abaId)
        {
            return ApiJsonRequest(string.Format("/business/{0}/payrun/{1}/file/aba/{2}", businessId, payRunId, abaId));
        }
    }
}