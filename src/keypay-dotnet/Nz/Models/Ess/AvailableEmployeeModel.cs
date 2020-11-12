using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class AvailableEmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string JobTitle { get; set; }
        public bool HasProfileImage { get; set; }
        public WhiteLabelBrandingModel Branding { get; set; }
        public int DefaultLocationId { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Region { get; set; }
    }
}
