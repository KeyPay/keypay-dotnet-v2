using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class FpsResponseXmlModel
    {
        public string Xml { get; set; }
        public UkLodgePayRunSubmissionResult Result { get; set; }
    }
}
