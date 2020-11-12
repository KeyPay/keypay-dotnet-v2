using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class ApiPaySlipKiwiSaverPaymentModel
    {
        public decimal EmployerContribution { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EsctContribution { get; set; }
    }
}
