# All regions

## Enum values removed

MessageTypeEnum.CancelAccount
MessageTypeEnum.InvoicePaymentSuccessNotification
MessageTypeEnum.InvoicePaymentFailedNotification

## Property types changed

DetailedActivityReportAsExcelQueryModel
    .FromDate DateTime -> DateTime?
    .ToDate DateTime -> DateTime?

DocumentAcknowledgementsReportQueryModel.EmployingEntityId int? -> int

## Method parameter orders changed

IEssFunction.MarkShiftNotesRead
IEssFunction.MarkShiftNotesReadAsync
IPayRunFunction.NetToGross
IPayRunFunction.NetToGrossAsync
IManagerFunction.SendPinResetEmail
IManagerFunction.SendPinResetEmailAsync
IManagerFunction.MarkShiftNotesRead
IManagerFunction.MarkShiftNotesReadAsync
IManagerFunction.SendPinResetSms
IManagerFunction.SendPinResetSmsAsync
IManagerFunction.UpdateCommentsInATimesheet
IManagerFunction.UpdateCommentsInATimesheetAsync
IManagerFunction.UpdateRosterShift
IManagerFunction.UpdateRosterShiftAsync
IRosterShiftFunction.UpdateRosterShift
IRosterShiftFunction.UpdateRosterShiftAsync
ITimeAttendanceFunction.CheckEmployee
ITimeAttendanceFunction.CheckEmployeeAsync
ITimeAttendanceFunction.VerifyKioskPin
ITimeAttendanceFunction.VerifyKioskPinAsync
ITimeAttendanceFunction.SendPinResetEmail
ITimeAttendanceFunction.SendPinResetEmailAsync
ITimeAttendanceFunction.MarkShiftNotesRead
ITimeAttendanceFunction.MarkShiftNotesReadAsync
ITimeAttendanceFunction.SendPinResetSms
ITimeAttendanceFunction.SendPinResetSmsAsync

## Return types changed

IEssFunction.SubmitOrUpdateTimesheet void -> EssTimesheetAndSummaryModel 
IEssFunction.SubmitOrUpdateTimesheetAsync Task -> Task<EssTimesheetAndSummaryModel>
IEssFunction.EditTimesheet void -> EssTimesheetAndSummaryModel
IEssFunction.EditTimesheetAsync Task -> Task<EssTimesheetAndSummaryModel>
IReportingFunction.GetPaySlipsByFinalisedPayRunId void -> byte[]
IReportingFunction.GetPaySlipsByFinalisedPayRunIdAsync Task -> Task<byte[]>
IReportingFunction.JournalReport void -> byte[]
IReportingFunction.JournalReportAsync Task -> Task<byte[]>

# Au

## Property types changed

AuApiPaySlipModel.TotalHours decimal -> decimal?

## Methods moved

KeyPayV2.Au.Functions.IOtherFunction.AuPayRunDetails_Get -> KeyPayV2.Au.Functions.IPayRunFunction.GetPayRunDetails
KeyPayV2.Au.Functions.IOtherFunction.AuPayRunDetails_GetAsync -> KeyPayV2.Au.Functions.IPayRunFunction.GetPayRunDetailsAsync

## Namespaces changed

KeyPayV2.Au.Models.Other.AuPayRunGrandTotalModel -> KeyPayV2.Au.Models.PayRun
KeyPayV2.Au.Models.Other.AuPayRunTotalDetailModel -> KeyPayV2.Au.Models.PayRun
KeyPayV2.Au.Models.Common.PayRunModel -> KeyPayV2.Au.Models.PayRun

# My

## Property types changed

MyApiPaySlipModel.TotalHours decimal -> decimal?

## Methods removed

KeyPayV2.My.Functions.IEssFunctiond.GetEnabledFeatures

## Namespaces changed

KeyPayV2.Common.Enums.EarningsReportDisplayEnum -> KeyPayV2.My.Enums

# Nz

## Methods moved

KeyPayV2.Nz.Functions.IOtherFunction.NzPayRunDetails_Get -> KeyPayV2.Nz.Functions.IPayRunFunction.GetPayRunDetails
KeyPayV2.Nz.Functions.IOtherFunction.NzPayRunDetails_GetAsync -> KeyPayV2.Nz.Functions.IPayRunFunction.GetPayRunDetailsAsync

## Return types changed

IPayRunFunction.ListPaySlipData Dictionary<String,NzApiPaySlipModel> -> Dictionary<String,NzApiPaySlipModelWithConfig>
IPayRunFunction.ListPaySlipDataAsync Task<Dictionary<String,NzApiPaySlipModel>> -> Task<Dictionary<String,NzApiPaySlipModelWithConfig>>
IPayRunFunction.GetPaySlipDataByEmployeeId NzApiPaySlipModel -> RNzApiPaySlipModelWithConfig
IPayRunFunction.GetPaySlipDataByEmployeeIdAsync Task<NzApiPaySlipModel> -> Task<RNzApiPaySlipModelWithConfig>
IEmployeeRecurringTransactionsFunction.ListEmployeeAdditionalEarnings -> List<AdditionalEarningsModel>
IEmployeeRecurringTransactionsFunction.ListEmployeeAdditionalEarningsAsync -> Task<List<AdditionalEarningsModel>>
IEmployeeRecurringTransactionsFunction.CreateEmployeeAdditionalEarning -> AdditionalEarningsModel
IEmployeeRecurringTransactionsFunction.CreateEmployeeAdditionalEarningAsync -> Task<AdditionalEarningsModel>
IEmployeeRecurringTransactionsFunction.GetEmployeeAdditionalEarningById -> NzAdditionalEarningsModel
IEmployeeRecurringTransactionsFunction.GetEmployeeAdditionalEarningByIdAsync -> Task<NzAdditionalEarningsModel>
IEmployeeRecurringTransactionsFunction.UpdateEmployeeAdditionalEarning -> NzAdditionalEarningsModel
IEmployeeRecurringTransactionsFunction.UpdateEmployeeAdditionalEarningAsync -> Task<NzAdditionalEarningsModel>
ILeaveCategoriesFunction.GetHolidayLeaveSettings BusinessHolidayLeaveSettingsDetailModel -> NzBusinessHolidayLeaveSettingsApiDetailModel
ILeaveCategoriesFunction.GetHolidayLeaveSettingsAsync Task<BusinessHolidayLeaveSettingsDetailModel> -> Task<NzBusinessHolidayLeaveSettingsApiDetailModel>

## Parameter types changed

ILeaveCategoriesFunction.SetHolidayLeaveSettings(int businessId, BusinessHolidayLeaveSettingsModel model) -> (int businessId, NzBusinessHolidayLeaveSettingsApiModel model)
ILeaveCategoriesFunction.SetHolidayLeaveSettingsAsync(int businessId, BusinessHolidayLeaveSettingsModel model) -> (int businessId, NzBusinessHolidayLeaveSettingsApiModel model)

## Types renamed

KeyPayV2.Nz.Models.PayRun.NzApiPaySlipModel -> NzApiPaySlipModelWithConfig
KeyPayV2.Nz.Models.EmployeeRecurringTransactions.AdditionalEarningsInputModel -> NzAdditionalEarningsInputModel
KeyPayV2.Nz.Models.EmployeeRecurringTransactions.AdditionalEarningsModel -> NzAdditionalEarningsModel
KeyPayV2.Nz.Models.LeaveCategories.BusinessHolidayLeaveSettingsDetailModel -> NzBusinessHolidayLeaveSettingsDetailModel
KeyPayV2.Nz.Models.LeaveCategories.BusinessHolidayLeaveSettingsModel -> NzBusinessHolidayLeaveSettingsModel
KeyPayV2.Nz.Models.PayRun.NzApiPaySlipModel -> NzApiPaySlipModelWithConfig

## Property types changed

KeyPayV2.Nz.Models.PayRun.NzApiPaySlipModelWithConfig.TotalHours decimal -> decimal?

## Namespaces changed

KeyPayV2.Nz.Models.Other.NzPayRunDetailsModel -> KeyPayV2.Nz.Models.PayRun
KeyPayV2.Nz.Models.Other.NzPayRunGrandTotalModel -> KeyPayV2.Nz.Models.PayRun
KeyPayV2.Nz.Models.Other.NzPayRunTotalDetailModel -> KeyPayV2.Nz.Models.PayRun
KeyPayV2.Nz.Models.Other.PayRunModel -> KeyPayV2.Nz.Models.PayRun

# Sg

## Methods moved

KeyPayV2.Sg.Functions.IOtherFunction.SgPayRunDetails_Get -> KeyPayV2.Sg.Functions.IPayRunFunction.GetPayRunDetails
KeyPayV2.Sg.Functions.IOtherFunction.SgPayRunDetails_GetAsync -> KeyPayV2.Sg.Functions.IPayRunFunction.GetPayRunDetailsAsync

## Namespaces changed

KeyPayV2.Sg.Models.Common.PayRunModel -> KeyPayV2.Sg.Models.PayRun
KeyPayV2.Sg.Models.Common.SgPayRunDetailsModel -> KeyPayV2.Sg.Models.PayRun
KeyPayV2.Sg.Models.Common.SgPayRunGrandTotalModel -> KeyPayV2.Sg.Models.PayRun
KeyPayV2.Sg.Models.Common.SgPayRunTotalDetailModel -> KeyPayV2.Sg.Models.PayRun

## Propertys types changed

SgApiPaySlipModel.TotalHours decimal -> decimal?

# Uk

## Types removed

KeyPayV2.Uk.Enums.SmpPayTypeEnum
KeyPayV2.Uk.Models.Other.P11GenerationModel
KeyPayV2.Uk.Models.Other.P11ReportDataModel
KeyPayV2.Uk.Models.Other.P11ReportDataRow
KeyPayV2.Uk.Models.Other.UkSmpApiRateResponseModel
KeyPayV2.Uk.Models.Other.UkSmpApiRequestModel
KeyPayV2.Uk.Models.Other.UkSmpApiResponseModel

## Methods removed

KeyPayV2.Uk.Functions.IOtherFunction
    .MockedLodgedPayRunTest_CreateMockedLodgedPayRun
    .MockedLodgedPayRunTest_CreateMockedLodgedPayRunAsync
    .UkBusinessPensionTest_SetProviderId
    .UkBusinessPensionTest_SetProviderIdAsync
    .UkGetP11ReportDataTest_Generate
    .UkGetP11ReportDataTest_Generate

IPayRunFunction.AddStatutoryMaternityPayAsync
IPayRunFunction.AddStatutoryMaternityPay

## Methods renamed

IPayRunFunction.UkPayRunDetails_GetAsync -> GetPayRunDetailsAsync
IPayRunFunction.UkPayRunDetails_Get -> GetPayRunDetails
IReportingFunction.PensionContributionsReport -> PensionContributionsReportData
IReportingFunction.PensionContributionsReportAsync -> PensionContributionsReportDataAsync
IReportingFunction.GetP32ReportAsync -> GetP32ReportDataAsync
IReportingFunction.GetP32Report -> GetP32ReportData

## Property types changed

UkApiPaySlipModel.TotalHours decimal -> decimal?

## Types renamed

KeyPayV2.Uk.Models.Reporting.GetP32ReportQueryModel -> GetP32ReportDataQueryModel
KeyPayV2.Uk.Models.Reporting.PensionContributionsReportQueryModel -> PensionContributionsReportDataQueryModel