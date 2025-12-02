using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Authentication
{
    public class GetUserBrandAssociationsResponseModel
    {
        public List<UserBrandAssociationModel> UserBrandAssociations { get; set; }
    }
}
