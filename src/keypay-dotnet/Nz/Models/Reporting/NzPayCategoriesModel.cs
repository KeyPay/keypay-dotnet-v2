using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class NzPayCategoriesModel
    {
        public decimal KiwiSaverEmployeeContribution { get; set; }
        public decimal KiwiSaverEmployerContribution { get; set; }
        public decimal EsctContribution { get; set; }
        public string PayCategory { get; set; }
        public string PayRun { get; set; }
        public DateTime DatePaid { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string Location { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
