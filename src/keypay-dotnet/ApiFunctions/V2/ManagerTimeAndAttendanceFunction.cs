using System.Collections.Generic;
using System.Net.Http;
using KeyPay.DomainModels.V2.TimeAndAttendance;
using KeyPay.Enums;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class ManagerTimeAndAttendanceFunction : BaseFunction
    {
        public ManagerTimeAndAttendanceFunction(ApiRequestExecutor api) : base(api)
        {
        }
        
        public List<BasicKioskEmployeeModel> GetStaff(int businessId, int kioskId)
        {
            return ApiRequest<List<BasicKioskEmployeeModel>>($"/business/{businessId}/manager/kiosk/{kioskId}/staff");
        }
        
        public BasicKioskEmployeeModel CheckId(int businessId, int kioskId, CheckKioskEmployeeIdModel model)
        {
            return ApiRequest<BasicKioskEmployeeModel, CheckKioskEmployeeIdModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkid", model, Method.POST);
        }
        
        public KioskEmployeeModel CheckPin(int businessId, int kioskId, CheckKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel, CheckKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/checkpin", model, Method.POST);
        }
        
        public KioskEmployeeModel ChangePin(int businessId, int kioskId, ChangeKioskPinModel model)
        {
            return ApiRequest<KioskEmployeeModel, ChangeKioskPinModel>($"/business/{businessId}/manager/kiosk/{kioskId}/changepin", model, Method.POST);
        }
        
        public HttpResponseMessage EmailReset(int businessId, int kioskId, PinResetModel model)
        {
            return ApiRequest<HttpResponseMessage, PinResetModel>($"/business/{businessId}/manager/kiosk/{kioskId}/emailreset", model, Method.POST);
        }
        
        public HttpResponseMessage SmsReset(int businessId, int kioskId, PinResetModel model)
        {
            return ApiRequest<HttpResponseMessage, PinResetModel>($"/business/{businessId}/manager/kiosk/{kioskId}/smsreset", model, Method.POST);
        }
        
        public KioskEmployeeModel ClockOn(int businessId, int kioskId, ClockOnModel model)
        {
            return ApiRequest<KioskEmployeeModel, ClockOnModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockon", model, Method.POST);
        }
        
        public KioskEmployeeModel ClockOff(int businessId, int kioskId, ClockOffModel model)
        {
            return ApiRequest<KioskEmployeeModel, ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/clockoff", model, Method.POST);
        }
        
        public KioskEmployeeModel StartBreak(int businessId, int kioskId, StartBreakModel model)
        {
            return ApiRequest<KioskEmployeeModel, StartBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/startbreak", model, Method.POST);
        }
        
        public KioskEmployeeModel EndBreak(int businessId, int kioskId, EndBreakModel model)
        {
            return ApiRequest<KioskEmployeeModel, EndBreakModel>($"/business/{businessId}/manager/kiosk/{kioskId}/endbreak", model, Method.POST);
        }
        
        public KioskEmployeeModel DiscardShift(int businessId, int kioskId, ClockOffModel model)
        {
            return ApiRequest<KioskEmployeeModel, ClockOffModel>($"/business/{businessId}/manager/kiosk/{kioskId}/discard", model, Method.POST);
        }
        
        public TimeAndAttendanceLookupDataModel GetLookupData(int businessId, int kioskId, int employeeId)
        {
            return ApiRequest<TimeAndAttendanceLookupDataModel>($"/business/{businessId}/manager/kiosk/{kioskId}/lookupdata/{employeeId}");
        }
        
        public IList<TimeAndAttendanceShiftModel> Shifts(int businessId, GetShiftsModel model)
        {
            return ApiRequest<List<TimeAndAttendanceShiftModel>, GetShiftsModel>($"/business/{businessId}/manager/kiosk/shifts", model, Method.POST);
        }
        
        public IList<ShiftNoteViewModel> GetShiftNotes(int businessId, int kioskId, int shiftId, int employeeId, bool isAdminInitiated = false, TimeAttendanceShiftNoteType? noteType = null)
        {
            var baseUrl = $"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes?EmployeeId={employeeId}";
            if (isAdminInitiated)
                baseUrl = $"{baseUrl}&IsAdminInitiated=true";
            if (noteType.HasValue)
                baseUrl = $"{baseUrl}&Type={noteType.ToString()}";

            return ApiRequest<List<ShiftNoteViewModel>>(baseUrl);
        }
        
        public ShiftNoteViewModel AddNote(int businessId, int kioskId, int shiftId, AddNoteModel model)
        {
            return ApiRequest<ShiftNoteViewModel, AddNoteModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes", model, Method.POST);
        }
        
        public HttpResponseMessage DeleteNote(int businessId, int kioskId, int shiftId, int noteId)
        {
            return ApiRequest<HttpResponseMessage>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/{noteId}", Method.DELETE);
        }

        public HttpResponseMessage MarkNotesRead(int businessId, int kioskId, int shiftId, MarkNotesReadViewModel model)
        {
            return ApiRequest<HttpResponseMessage, MarkNotesReadViewModel>($"/business/{businessId}/manager/kiosk/{kioskId}/shift/{shiftId}/notes/read-state", model, Method.POST);
        }
    }
}