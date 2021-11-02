using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.EmployeeBankAccount;

namespace KeyPayV2.Au.Functions
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
        public List<AuBankAccountModel> ListBankAccounts(int businessId, int employeeId)
        {
            return ApiRequest<List<AuBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.GET);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<AuBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AuBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public AuSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, AuBankAccountModel model)
        {
            return ApiRequest<AuSaveBankAccountResponseModel,AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.POST);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<AuSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, AuBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuSaveBankAccountResponseModel,AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public AuBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.GET);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<AuBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public AuSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<AuSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<AuSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public AuSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, AuBankAccountModel model)
        {
            return ApiRequest<AuSaveBankAccountResponseModel,AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<AuSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, AuBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AuSaveBankAccountResponseModel,AuBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.PUT, cancellationToken);
        }
    }
}
