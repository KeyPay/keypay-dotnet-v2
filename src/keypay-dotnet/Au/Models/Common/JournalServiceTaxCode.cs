using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class JournalServiceTaxCode
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
    }
}
