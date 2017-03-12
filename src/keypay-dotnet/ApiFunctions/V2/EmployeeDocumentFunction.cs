using System.Collections.Generic;
using System.Linq;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Employee;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class EmployeeDocumentFunction : BaseFunction
    {
        public EmployeeDocumentFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployeeDocumentModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeDocumentModel>>(string.Format("/business/{0}/employee/{1}/document", businessId, employeeId));
        }

        public EmployeeDocumentModel Get(int businessId, int employeeId, int documentId)
        {
            return ApiRequest<EmployeeDocumentModel>(string.Format("/business/{0}/employee/{1}/document/{2}", businessId, employeeId, documentId));
        }

        public DocumentFile Content(int businessId, int employeeId, int documentId)
        {
            return ApiByteArrayRequest<DocumentFile>(string.Format("/business/{0}/employee/{1}/document/{2}/content", businessId, employeeId, documentId));
        }

        public EmployeeDocumentModel Create(int businessId, int employeeId, FileUploadModel document, bool visible = false)
        {
            var result = ApiFileRequest<List<EmployeeDocumentModel>>(string.Format("/business/{0}/employee/{1}/document?visible={2}", businessId, employeeId, visible), document);
            return result.First();
        }

        public List<EmployeeDocumentModel> Create(int businessId, int employeeId, List<FileUploadModel> documents, bool visible = false)
        {
            var result = ApiFileRequest<List<EmployeeDocumentModel>>(string.Format("/business/{0}/employee/{1}/document?visible={2}", businessId, employeeId, visible), documents);
            return result;
        }

        public void Delete(int businessId, int employeeId, int id)
        {
            ApiRequest(string.Format("/business/{0}/employee/{1}/document/{2}", businessId, employeeId, id), Method.DELETE);
        }

        public EmployeeDocumentModel Put(int businessId, int employeeId, int id, bool visible)
        {
            var result = ApiRequest<EmployeeDocumentModel, dynamic>(string.Format("/business/{0}/employee/{1}/document", businessId, employeeId), new { id, visible }, Method.PUT);
            return result;
        }
    }
}