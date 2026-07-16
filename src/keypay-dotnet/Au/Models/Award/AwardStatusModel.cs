using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Award
{
    public class AwardStatusModel
    {
        public int Id { get; set; }
        public int AwardId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AwardImportStatus Status { get; set; }
        public DateTime? LatestVersionDate { get; set; }
    }
}
