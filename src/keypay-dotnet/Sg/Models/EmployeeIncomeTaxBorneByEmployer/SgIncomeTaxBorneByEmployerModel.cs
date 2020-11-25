using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeIncomeTaxBorneByEmployer
{
    public class SgIncomeTaxBorneByEmployerModel
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        public TaxBorneByEmployerType TaxBorneByEmployerType { get; set; }
        public decimal? BorneByEmployerAmount { get; set; }
        public decimal? BorneByEmployeeAmount { get; set; }
    }
}
