using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class P45ReportResponseModel
    {
        public string TotalPayThisEmployment { get; set; }
        public string TotalTaxThisEmployment { get; set; }
        public string PayrollNumber { get; set; }
        public string Male { get; set; }
        public string Female { get; set; }
        public string DateOfBirthDD { get; set; }
        public string DateOfBirthMM { get; set; }
        public string DateOfBirthYYYY { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePostcode { get; set; }
        public string EmployerNameAndAddress { get; set; }
        public string EmployerPostcode { get; set; }
        public string SignedDateDD { get; set; }
        public string SignedDateMM { get; set; }
        public string SignedDateYYYY { get; set; }
        public P45SharedDetailsModel SharedDetails { get; set; }
    }
}
