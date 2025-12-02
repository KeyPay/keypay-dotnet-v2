using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Authentication
{
    public class UserBrandAssociationModel
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
