using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class OpeningBalancesStatutoryContributionsModel
    {
        public decimal PcbAmount { get; set; }
        public decimal CP38Amount { get; set; }
        public decimal MandatoryEmployeeEpfAmount { get; set; }
        public decimal MandatoryEmployerEpfAmount { get; set; }
        public decimal AdditionalEmployeeEpfAmount { get; set; }
        public decimal AdditionalEmployerEpfAmount { get; set; }
        public decimal EmployeeEisAmount { get; set; }
        public decimal EmployerEisAmount { get; set; }
        public decimal EmployeeSocsoAmount { get; set; }
        public decimal EmployerSocsoAmount { get; set; }
        public decimal HrdfAmount { get; set; }
        public decimal Tp1ZakatAmount { get; set; }
        public decimal Tp1ReliefAmount { get; set; }
    }
}
