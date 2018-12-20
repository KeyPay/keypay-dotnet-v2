using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ExpenseReferenceData
    {
        public IList<ExpenseCategoryResponseModel> ExpenseCategories { get; set; }
        public IList<JournalServiceTaxCode> TaxCodes { get; set; }
        public IList<LocationModel> Locations { get; set; }
        public int DefaultLocationId { get; set; }
    }
}
