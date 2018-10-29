using System.Collections.Generic;
using KeyPay.DomainModels.V2.TimeAndAttendance;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerKioskFunction : BaseFunction
    {
        public ManagerKioskFunction(ApiRequestExecutor api) : base(api)
        {
        }
        
        public List<TimeAndAttendanceKioskModel> GetAll(int businessId)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/manager/kiosk");
        }
        
        public TimeAndAttendanceKioskModel Get(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/manager/kiosk/{id}");
        }
    }
}