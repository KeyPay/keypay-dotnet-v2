using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class DocumentModel
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool VisibleToAllEmployees { get; set; }
        public List<EmployeeGroupModel> SelectedGroups { get; set; }
    }
}