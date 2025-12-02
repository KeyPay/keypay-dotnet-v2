using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Authentication
{
    public class GetUserBrandAssociationsResponseModel
    {
        public List<UserBrandAssociationModel> UserBrandAssociations { get; set; }
    }
}
