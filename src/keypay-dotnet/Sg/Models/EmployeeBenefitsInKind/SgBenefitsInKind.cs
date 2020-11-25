using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeBenefitsInKind
{
    public class SgBenefitsInKind
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public DateTime? PeriodOfOccupationToDate { get; set; }
        public DateTime? PeriodOfOccupationFromDate { get; set; }
        public int? EmployeesSharingPremises { get; set; }
        public BenefitType? BenefitType { get; set; }
        public decimal? Benefit { get; set; }
        public FurnishedType? FurnishedType { get; set; }
        public decimal? TotalRentPaidByEmployee { get; set; }
        public decimal? UtilitiesGadgets { get; set; }
        public decimal? Driver { get; set; }
        public decimal? ServantUpkeepOfCompound { get; set; }
        public decimal? CostOfAccommodation { get; set; }
        public decimal? PaidByEmployee { get; set; }
        public decimal? InterestPaymentMadeByEmployer { get; set; }
        public decimal? InsurancePremiumsPaidByEmployer { get; set; }
        public decimal? FreeOrSubsidisedHolidays { get; set; }
        public decimal? EducationalExpense { get; set; }
        public decimal? EntranceTransferFeesAnnualSubscription { get; set; }
        public decimal? GainsFromAsset { get; set; }
        public decimal? CostOfMotorVehiclesGivenToEmployee { get; set; }
        public decimal? CarBenefits { get; set; }
        public decimal? CostOfHomeLeavePassagesIncidentalBenefits { get; set; }
        public decimal? OtherNonMonetaryAwardsBenefits { get; set; }
    }
}
