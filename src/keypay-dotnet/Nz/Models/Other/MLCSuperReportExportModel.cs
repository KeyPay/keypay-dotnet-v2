using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class MLCSuperReportExportModel
    {
        public string Code { get; set; }
        public string FundCode { get; set; }
        public string Spin { get; set; }
        public string MemberCode { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string MobilePhone { get; set; }
        public string StartDate { get; set; }
        public string AnnualSalary { get; set; }
        public string PayGroup { get; set; }
        public string BenefitCategory { get; set; }
        public string EndDate { get; set; }
        public string SuperGuarantee { get; set; }
        public string EmployerAdditional { get; set; }
        public string MemberVoluntary { get; set; }
        public string SalarySacrifice { get; set; }
        public string SpouseContribution { get; set; }
        public string TaxFileNumber { get; set; }
        public string EmploymentStatus { get; set; }
    }
}
