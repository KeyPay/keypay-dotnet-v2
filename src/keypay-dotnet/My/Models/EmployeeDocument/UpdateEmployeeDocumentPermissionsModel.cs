using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployeeDocument
{
    public class UpdateEmployeeDocumentPermissionsModel
    {
        public int Id { get; set; }
        public bool Visible { get; set; }
        public bool RequiresEmployeeAcknowledgement { get; set; }
        public bool SendNotificationToEmployee { get; set; }
        public bool SendNotificationImmediately { get; set; }
        public DateTime? SendInitialNotificationOn { get; set; }
        public int? SendReminderEveryXDays { get; set; }
    }
}
