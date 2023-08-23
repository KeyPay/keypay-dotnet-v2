using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class InconsistentNIRecordsModel
    {
        public List<InconsistentNIRecordModel> NiRecords { get; set; }
        public List<Int32> EmployeeIds { get; set; }
        public List<Int32> NiRecordIds { get; set; }
    }
}
