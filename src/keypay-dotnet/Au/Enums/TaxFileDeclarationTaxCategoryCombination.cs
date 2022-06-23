using System;
using System.Collections.Generic;

namespace KeyPayV2.Au.Enums
{
    public enum TaxFileDeclarationTaxCategoryCombination
    {
        Actor_WithTaxFreeThreshold,
        Actor_NoTaxFreeThreshold,
        Actor_LimitedPerformancePerWeek,
        Actor_Promotional,
        HorticulturalistShearer_WithTaxFreeThreshold,
        HorticulturalistShearer_ForeignResident,
        SeniorPensioner_Single,
        SeniorPensioner_Married,
        SeniorPensioner_SeparatedCoupleIllness,
        ATODefined_DeathBeneficiary,
        ATODefined_DownwardVariation,
        ATODefined_NonEmployee,
        DailyCasual
    }
}
