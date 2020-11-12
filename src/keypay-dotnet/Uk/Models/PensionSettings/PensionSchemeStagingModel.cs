using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PensionSettings
{
    public class PensionSchemeStagingModel
    {
        public DateTime StagingDate { get; set; }
        public DateTime AutoReEnrolmentDate { get; set; }
        public bool IncludeOptedOutEmployees { get; set; }
    }
}
