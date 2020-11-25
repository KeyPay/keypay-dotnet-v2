using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Employee
{
    public class OpeningBalancesLumpSumPaymentModel
    {
        public string Name { get; set; }
        public PayCategoryType PayCategoryType { get; set; }
        public decimal? TaxFreeComponent { get; set; }
        public decimal? TaxableComponent { get; set; }
        public decimal? TaxWithheld { get; set; }
    }
}
