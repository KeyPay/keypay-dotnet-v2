using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Ess
{
    public class IrasPaymentSummaryModel
    {
        public int Id { get; set; }
        public int IrasSnapshotId { get; set; }
        public string Period { get; set; }
        public string FormType { get; set; }
        public string DownloadUrl { get; set; }
    }
}
