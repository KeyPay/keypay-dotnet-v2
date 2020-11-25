using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgCpfApiModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeNric { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime EmployeeStartDate { get; set; }
        public DateTime? EmployeeEndDate { get; set; }
        public string EmployingEntity { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal OrdinaryWages { get; set; }
        public decimal AdditionalWages { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
