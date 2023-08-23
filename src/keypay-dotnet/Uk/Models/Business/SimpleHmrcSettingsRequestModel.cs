using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class SimpleHmrcSettingsRequestModel
    {
        public string UniqueTaxPayerReference { get; set; }
        public string AccountsOfficeReference { get; set; }
        public string Paye { get; set; }
    }
}
