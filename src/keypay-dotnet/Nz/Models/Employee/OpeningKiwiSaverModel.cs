using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class OpeningKiwiSaverModel
    {
        public decimal EmployeeContributionAmount { get; set; }
        public decimal EmployerContributionAmount { get; set; }
        public decimal EsctAmount { get; set; }
    }
}
