using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.EmployeeBankAccount;

namespace KeyPayV2.Nz.Functions
{
    public interface IEmployeeBankAccountFunction
    {
        List<NzBankAccountModel> ListBankAccounts(int businessId, int employeeId);
        Task<List<NzBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        NzSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, NzBankAccountModel model);
        Task<NzSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, NzBankAccountModel model, CancellationToken cancellationToken = default);
        NzBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId);
        Task<NzBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        NzSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId);
        Task<NzSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        NzSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, NzBankAccountModel model);
        Task<NzSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, NzBankAccountModel model, CancellationToken cancellationToken = default);
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
        public List<NzBankAccountModel> ListBankAccounts(int businessId, int employeeId)
        {
            return ApiRequest<List<NzBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<NzBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<NzBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public NzSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, NzBankAccountModel model)
        {
            return ApiRequest<NzSaveBankAccountResponseModel,NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<NzSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, NzBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSaveBankAccountResponseModel,NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public NzBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<NzBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public NzSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<NzSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<NzSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public NzSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, NzBankAccountModel model)
        {
            return ApiRequest<NzSaveBankAccountResponseModel,NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<NzSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, NzBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzSaveBankAccountResponseModel,NzBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put, cancellationToken);
        }
    }
}
