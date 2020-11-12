using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EssDocumentModel
    {
        public string Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool RequiresEmployeeAcknowledgement { get; set; }
        public DateTime? DateAcknowledged { get; set; }
    }
}
