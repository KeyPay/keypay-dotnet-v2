using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Timesheets
{
    public class CreateTimesheetLineQueryModel
    {
        public bool EnforceUniqueExternalId { get; set; }
    }
}
