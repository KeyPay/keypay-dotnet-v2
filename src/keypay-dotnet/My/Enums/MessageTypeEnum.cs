using System;
using System.Collections.Generic;

namespace KeyPayV2.My.Enums
{
    public enum MessageTypeEnum
    {
        NewPaySlipAvailable,
        NewUser,
        RecoverPassword,
        EmployeeAccess,
        BusinessAccess,
        Invoice,
        AutomatedPassword,
        LeaveRequestNotification,
        RestrictedAccess,
        ResendPayslip,
        PaymentSummaryAvailable,
        SuperPaymentsUpdateResults,
        NewShiftsPublished,
        ShiftsUnpublished,
        ShiftDeclined,
        KioskAccessGranted,
        DailyNotifications,
        BsbDataImported,
        InvoiceeCardDetailsRemoved,
        WhiteLabelManagerAccess,
        ResellerAccess,
        DirectDepositReminder,
        ExpenseRequestNotification,
        UnavailabilityNotification,
        ReportPackGenerated,
        ReportPackError,
        SystemPublicHolidayImport,
        TimesheetRejected,
        ShiftRepublished,
        PendingShiftsReminder,
        EmployeeShiftActionTimeout,
        InitiateEmployeeOnboarding,
        FollowUpEmployeeOnboarding,
        CompleteEmployeeOnboarding,
        NewShiftsPreAccepted,
        PayRunTaskNotification,
        ShiftSwapCancelled,
        BulkShiftSwapsCancelled,
        ShiftSwapAwaitingApproval,
        ShiftSwapProposed,
        ShiftSwapAccepted,
        ShiftSwapDeclined,
        ShiftSwapRejected,
        ShiftSwapApproved,
        P60Available,
        P60Error,
        LeavingEmployeeFormNotification,
        AutoEnrolmentNotification,
        LodgementNotification,
        TwoFactorLogin,
        TwoFactorChallenge,
        ConfirmEmailAddress,
        ConfirmMobilePhone,
        DocumentNotificationInitial,
        DocumentNotificationInitialWithAcknowledgement,
        DocumentNotificationReminder,
        DocumentAcknowledgedNotification,
        InitiateEmployeeOnboardingAdmin,
        PayEventRequestAuthority,
        PayEventApprovedOrRejected,
        ShiftBidAccepted,
        EmployeeDetailsUpdated,
        BankAccountDetailsUpdated,
        SuperDetailsUpdated,
        ManagerShiftActionTimeout,
        SuperFundNotificationNewMember,
        SuperPaymentDishonour,
        KiwiSaverDetailsUpdated,
        AutoEnrolmentPostponementNotification,
        AutomatedPayRunErrorCreation,
        AutomatedPayRunErrorProcessing,
        AutomatedPayRunErrorFinalisation,
        AutomatedPayRunErrorPostFinalise,
        AutomatedPayRunSuccessAndFinalised,
        AutomatedPayRunSuccessNotFinalised,
        AutomatedPayRunCreation,
        PayRunUsageBillingFailures,
        IncomeStatementAvailable,
        MaliciousFileNotificationAdmin,
        UserAccountLocked,
        MaliciousFileNotificationEmployee,
        SuperFundRefundNotification,
        SuperBatchCancelledNotification,
        JobKeeperEmployeeNomination,
        HmrcPaymentReminder,
        IrasFormAvailable,
        HmrcPaymentReminderSendFailure,
        SyncCancelledSuperBatchesFromBeam,
        EAFormIncomeTaxAvailable,
        PCB2FormAvailable,
        JobMakerEmployeeNomination,
        EarningsCertificateAvailable,
        P11dAvailable,
        PayRunApprovalNotification,
        PayRunApprovalReminder,
        PayRunStatusChanged,
        QualificationUpdatedNotification,
        QualificationExpiringNotification,
        QualificationExpiredNotification,
        CreditCardExpiringReminder,
        ResendPaymentAndDeductionStatement,
        EmployeeSelfSetupReminder,
        EmployeeOnboardingP45Uploaded,
        BusinessAccessGranted,
        InitiateEmployeeOnboardingWithContract,
        SignatoryContract,
        WorkEligibilityExpiringNotification,
        WorkEligibilityExpiredNotification,
        ContractSignedEmployeeNotification,
        ContractSignedEmployerNotification,
        InitiateEmployeeOnboardingWithLogin,
        AuthorisingSignatoryNotification,
        IntegrationCustomFeatureRequest,
        UserAccountLockedByAdmin,
        UserAccountUnlockedByAdmin,
        EmailAddressChanged,
        EmailAddressConfirmChanged,
        RecoveryEmailAddressChanged,
        RecoveryEmailAddressConfirmChanged,
        FraudProtectionCheckResult,
        SuspiciousLogin,
        ImpossibleTravelLogin,
        PaymentApprovalNotification,
        PaymentApprovalReminder,
        PaymentApprovalStatusChanged,
        BulkActionUserPasswordChanged,
        BulkActionUserAccountLocked,
        BulkActionUserAccountUnlocked,
        P60DownloadReady,
        PartnerBusinessDeactivationNotification30Days,
        EHDirectBusinessDeactivationNotification30Days,
        RecoverTwoFactorAuthentication,
        AccountRecoverySubmitted,
        ScheduledJournalExportFailed,
        AddEmployeeEmployeeOnboarding,
        FeatureUsageReportGenerated,
        NotifyAkahuUserOfFailedPaymentStatus
    }
}
