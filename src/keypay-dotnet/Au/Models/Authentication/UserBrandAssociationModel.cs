using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Authentication
{
    public class UserBrandAssociationModel
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
