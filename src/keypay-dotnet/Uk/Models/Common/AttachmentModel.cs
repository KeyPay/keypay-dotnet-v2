using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class AttachmentModel
    {
        public int? Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Url { get; set; }
        public DateTime? DateScanned { get; set; }
        public bool? IsInfected { get; set; }
    }
}
