using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class JournalServiceTaxCode
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
    }
}
