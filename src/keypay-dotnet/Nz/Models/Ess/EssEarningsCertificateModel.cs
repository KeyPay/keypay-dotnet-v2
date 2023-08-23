using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EssEarningsCertificateModel
    {
        public int Id { get; set; }
        public int FinancialYearEnding { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool Notified { get; set; }
        public DateTime? NotifiedOn { get; set; }
    }
}
