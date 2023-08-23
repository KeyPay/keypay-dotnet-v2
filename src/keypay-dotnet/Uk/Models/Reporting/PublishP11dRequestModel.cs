using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class PublishP11dRequestModel
    {
        public int TaxYear { get; set; }
        public int EmployeeId { get; set; }
    }
}
