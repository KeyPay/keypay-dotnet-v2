using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeBankAccount;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeBankAccountFunction : BaseFunction
    {
        public EmployeeBankAccountFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public List<UkBankAccountModel> ListBankAccounts(int businessId, int employeeId)
        {
            return ApiRequest<List<UkBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount");
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public UkSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, UkBankAccountModel model)
        {
            return ApiRequest<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.POST);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public UkBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}");
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public UkSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<UkSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.DELETE);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public UkSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, UkBankAccountModel model)
        {
            return ApiRequest<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.PUT);
        }
    }
}
