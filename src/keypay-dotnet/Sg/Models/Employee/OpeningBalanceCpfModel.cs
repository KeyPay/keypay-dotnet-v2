using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Employee
{
    public class OpeningBalanceCpfModel
    {
        public decimal? CpfEmployerContributionAmount { get; set; }
        public decimal? CpfEmployeeContributionAmount { get; set; }
        public decimal? EmployerVoluntaryCpfAmount { get; set; }
        public decimal? EmployerVoluntaryMediSaveAmount { get; set; }
    }
}
