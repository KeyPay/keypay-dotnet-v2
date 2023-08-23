using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class PeriodOfLeaveModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public UkStatutorySickLeaveModel Ssp { get; set; }
        public UkOccupationalAbsenceModel Osp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveCategoryTypeEnum? LeaveCategoryType { get; set; }
        public List<StatutoryLeaveLogEvent> Log { get; set; }
        public bool IsReadOnly { get; set; }
        public bool CanDelete { get; set; }
        public bool IsLinkedToOccupationalAbsence { get; set; }
        public int? PayRunId { get; set; }
    }
}
