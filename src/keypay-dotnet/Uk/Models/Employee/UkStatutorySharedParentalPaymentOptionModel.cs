using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkStatutorySharedParentalPaymentOptionModel
    {
        public int Id { get; set; }
        public int WeekNumber { get; set; }
        public bool Offset { get; set; }
        public bool Pay { get; set; }
    }
}
