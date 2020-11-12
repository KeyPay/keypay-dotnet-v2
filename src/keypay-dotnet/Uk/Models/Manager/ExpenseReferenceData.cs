using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ExpenseReferenceData
    {
        public IList<ExpenseCategoryResponseModel> ExpenseCategories { get; set; }
        public IList<ExpenseTaxCode> TaxCodes { get; set; }
        public IList<LocationModel> Locations { get; set; }
        public int DefaultLocationId { get; set; }
    }
}
