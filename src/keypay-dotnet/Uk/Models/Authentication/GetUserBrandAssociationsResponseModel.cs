using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Authentication
{
    public class GetUserBrandAssociationsResponseModel
    {
        public List<UserBrandAssociationModel> UserBrandAssociations { get; set; }
    }
}
