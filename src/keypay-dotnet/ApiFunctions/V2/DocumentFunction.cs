using System.Collections.Generic;
using System.Linq;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class DocumentFunction : BaseFunction
    {
        public DocumentFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<DocumentModel> List(int businessId)
        {
            return ApiRequest<List<DocumentModel>>(string.Format("/business/{0}/document", businessId));
        }

        public DocumentModel Get(int businessId, int documentId)
        {
            return ApiRequest<DocumentModel>(string.Format("/business/{0}/document/{1}", businessId, documentId));
        }

        public DocumentFile Content(int businessId, int documentId)
        {
            return ApiByteArrayRequest<DocumentFile>(string.Format("/business/{0}/document/{1}/content", businessId, documentId));
        }

        public DocumentModel Create(int businessId, FileUploadModel document, bool visibleToAll = false, List<int> employeeGroups = null)
        {
            var result = ApiFileRequest<List<DocumentModel>>(string.Format("/business/{0}/document?visibleToAll={1}", businessId, visibleToAll), document);
            if (employeeGroups == null || !employeeGroups.Any())
            {
                return result != null ? result.FirstOrDefault() : null;
            }

            if (result == null || result.FirstOrDefault() == null)
            {
                return null;
            }

            var id = result.First().Id;
            return ApiRequest<DocumentModel, dynamic>(string.Format("/business/{0}/document", businessId), new { id, visibleToAll, employeeGroups }, Method.PUT);
        }

        public List<DocumentModel> Create(int businessId, List<FileUploadModel> documents, bool visibleToAll = false, List<int> employeeGroups = null)
        {
            var result = ApiFileRequest<List<DocumentModel>>(string.Format("/business/{0}/document?visibleToAll={1}", businessId, visibleToAll), documents);
            if (employeeGroups == null || !employeeGroups.Any())
            {
                return result;
            }

            if (result == null || !result.Any())
            {
                return null;
            }

            var docs = new List<DocumentModel>();
            foreach (var file in result)
            {
                var id = file.Id;
                docs.Add(ApiRequest<DocumentModel, dynamic>(string.Format("/business/{0}/document", businessId), new { id, visibleToAll, employeeGroups }, Method.PUT));
            }
            return docs;
        }

        public void Delete(int businessId, int id)
        {
            ApiRequest(string.Format("/business/{0}/document/{1}", businessId, id), Method.DELETE);
        }

        public DocumentModel Put(int businessId, int id, bool visibleToAll, List<int> employeeGroups)
        {
            var result = ApiRequest<DocumentModel, dynamic>(string.Format("/business/{0}/document", businessId), new { id, visibleToAll, employeeGroups }, Method.PUT);
            return result;
        }
    }
}