using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.EmployeeBankAccount;

namespace KeyPayV2.Uk.Functions
{
    public interface IEmployeeBankAccountFunction
    {
        List<UkBankAccountModel> ListBankAccounts(int businessId, int employeeId);
        Task<List<UkBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        UkSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, UkBankAccountModel model);
        Task<UkSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, UkBankAccountModel model, CancellationToken cancellationToken = default);
        UkBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId);
        Task<UkBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        UkSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId);
        Task<UkSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        UkSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, UkBankAccountModel model);
        Task<UkSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, UkBankAccountModel model, CancellationToken cancellationToken = default);
    }
    public class EmployeeBankAccountFunction : BaseFunction, IEmployeeBankAccountFunction
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
            return ApiRequest<List<UkBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<UkBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public UkSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, UkBankAccountModel model)
        {
            return ApiRequest<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<UkSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, UkBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public UkBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<UkBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public UkSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<UkSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<UkSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public UkSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, UkBankAccountModel model)
        {
            return ApiRequest<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<UkSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, UkBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkSaveBankAccountResponseModel,UkBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put, cancellationToken);
        }
    }
}
