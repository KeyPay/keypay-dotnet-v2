using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class DocumentModel
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool VisibleToAllEmployees { get; set; }
        public List<EmployeeGroupItemModel> SelectedGroups { get; set; }
        public List<LocationItemModel> SelectedLocations { get; set; }
        public bool RequiresEmployeeAcknowledgement { get; set; }
        public bool SendNotificationToEmployee { get; set; }
        public bool SendNotificationImmediately { get; set; }
        public DateTime? SendInitialNotificationOn { get; set; }
        public int? SendReminderEveryXDays { get; set; }
    }
}
