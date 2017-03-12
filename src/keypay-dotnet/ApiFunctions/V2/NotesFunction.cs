using System.Collections.Generic;
using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class NotesFunction : BaseFunction
    {
        public NotesFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployeeNoteModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeNoteModel>>("/business/" + businessId + "/employee/" + employeeId + "/notes");
        }

        public void Create(int businessId, int employeeId, string note)
        {
            ApiRequest("/business/" + businessId + "/employee/" + employeeId + "/notes", new {note}, Method.POST);
        }
    }
}