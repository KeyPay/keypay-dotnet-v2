using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class P45SharedDetailsModel
    {
        public string EmployerPayeOfficeNumber { get; set; }
        public string EmployerPayeReferenceNumber { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public string Title { get; set; }
        public string FamilyName { get; set; }
        public string FirstNames { get; set; }
        public string LeavingDateDD { get; set; }
        public string LeavingDateMM { get; set; }
        public string LeavingDateYYYY { get; set; }
        public string DeductStudentLoan { get; set; }
        public string TaxCode { get; set; }
        public string WeekOneOrMonthOne { get; set; }
        public string WeekNumber { get; set; }
        public string MonthNumber { get; set; }
        public string PayToDate { get; set; }
        public string TaxToDate { get; set; }
    }
}
