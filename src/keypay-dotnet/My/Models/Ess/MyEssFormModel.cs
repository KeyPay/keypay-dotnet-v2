using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyEssFormModel
    {
        public int Id { get; set; }
        public int TaxYear { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool Notified { get; set; }
        public DateTime? NotifiedOn { get; set; }
    }
}
