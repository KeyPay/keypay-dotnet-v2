using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Manager
{
    public class ManagerBiddableRosterShiftModel
    {
        public int TotalBiddingEmployees { get; set; }
        public IList<BiddingEmployee> BiddingEmployees { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public decimal? Cost { get; set; }
        public string CostFormatted { get; set; }
        public IList<String> Warnings { get; set; }
        public bool IsLeaveBasedRosterShift { get; set; }
        public ManagerCurrentRosterShift CurrentShift { get; set; }
        public int Id { get; set; }
        public string Token { get; set; }
        public IList<QualificationModel> Qualifications { get; set; }
        public IList<RosterShiftBreakApiModel> Breaks { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public int? ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        public RosterShiftRole Role { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public bool Published { get; set; }
        public bool Accepted { get; set; }
        public RosterShiftSwapModel PendingSwap { get; set; }
        public DateTime? DatePublished { get; set; }
        public bool Biddable { get; set; }
    }
}
