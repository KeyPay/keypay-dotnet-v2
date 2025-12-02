using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Authentication
{
    public class UserBrandAssociationModel
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
