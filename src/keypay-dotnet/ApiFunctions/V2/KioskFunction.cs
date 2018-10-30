using System.Collections.Generic;
using KeyPay.DomainModels.V2.TimeAndAttendance;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class KioskFunction : BaseFunction
    {
        public KioskFunction(ApiRequestExecutor api) : base(api)
        {
        }
        
        public List<TimeAndAttendanceKioskModel> GetAll(int businessId)
        {
            return ApiRequest<List<TimeAndAttendanceKioskModel>>($"/business/{businessId}/kiosk");
        }
        
        public TimeAndAttendanceKioskModel Get(int businessId, int id)
        {
            return ApiRequest<TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk/{id}");
        }

        public TimeAndAttendanceKioskModel Post(int businessId, TimeAndAttendanceKioskModel kiosk)
        {
            return ApiRequest<TimeAndAttendanceKioskModel, TimeAndAttendanceKioskModel>($"/business/{businessId}/kiosk", kiosk, Method.POST);
        }
        
    }
}