using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class P11ReportDataModel
    {
        public string EmployersName { get; set; }
        public string EmployersPayeReference { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Forenames { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool CompanyDirector { get; set; }
        public string NationalInsuranceNumberEncrypted { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public List<P11ReportDataRow> RowData { get; set; }
    }
}
