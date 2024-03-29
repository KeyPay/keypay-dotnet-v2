using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class SaveLeaveAccrualModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SaveLeaveAccrualTypeEnum AccrualType { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public int LeaveCategoryId { get; set; }
        public bool ApplyLeaveLoading { get; set; }
        public bool AdjustEarnings { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
