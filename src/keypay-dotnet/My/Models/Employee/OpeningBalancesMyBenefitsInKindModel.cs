using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class OpeningBalancesMyBenefitsInKindModel
    {
        public IList<OpeningBalancesMyBenefitsInKindItemModel> BenefitsInKindItems { get; set; }
    }
}
