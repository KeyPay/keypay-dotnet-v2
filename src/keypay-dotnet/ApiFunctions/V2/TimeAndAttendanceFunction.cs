using KeyPay.DomainModels.V2.TimeAndAttendance;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class TimeAndAttendanceFunction : BaseFunction
    {
        public TimeAndAttendanceFunction(ApiRequestExecutor api) : base(api)
        {
        }
        
        public BasicKioskEmployeeModel PostStaff(int businessId, int kioskId, KioskCreateEmployeeModel model)
        {
            return ApiRequest<BasicKioskEmployeeModel, KioskCreateEmployeeModel>($"/business/{businessId}/kiosk/{kioskId}/staff", model, Method.POST);
        }
    }
}