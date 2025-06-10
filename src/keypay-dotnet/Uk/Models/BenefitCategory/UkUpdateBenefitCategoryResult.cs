using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.BenefitCategory
{
    public class UkUpdateBenefitCategoryResult
    {
        public UkBenefitCategoryReadModel BenefitCategory { get; set; }
        public IList<Int32> EmployeeIdsToUpdate { get; set; }
        public IList<Int32> EmployeeIdsUpdated { get; set; }
    }
}
