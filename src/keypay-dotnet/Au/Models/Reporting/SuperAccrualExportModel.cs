using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class SuperAccrualExportModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime? AccrualDate { get; set; }
        public string AccrualType { get; set; }
        public decimal AccrualAmount { get; set; }
    }
}
