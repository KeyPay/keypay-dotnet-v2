using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.EmployeeBankAccount;

namespace KeyPayV2.Sg.Functions
{
    public interface IEmployeeBankAccountFunction
    {
        List<SgBankAccountModel> ListBankAccounts(int businessId, int employeeId);
        Task<List<SgBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        SgSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, SgBankAccountModel model);
        Task<SgSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, SgBankAccountModel model, CancellationToken cancellationToken = default);
        SgBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId);
        Task<SgBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        SgSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId);
        Task<SgSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        SgSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, SgBankAccountModel model);
        Task<SgSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, SgBankAccountModel model, CancellationToken cancellationToken = default);
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
        public List<SgBankAccountModel> ListBankAccounts(int businessId, int employeeId)
        {
            return ApiRequest<List<SgBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<SgBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public SgSaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, SgBankAccountModel model)
        {
            return ApiRequest<SgSaveBankAccountResponseModel,SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<SgSaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, SgBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgSaveBankAccountResponseModel,SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public SgBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<SgBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public SgSaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<SgSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<SgSaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgSaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public SgSaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, SgBankAccountModel model)
        {
            return ApiRequest<SgSaveBankAccountResponseModel,SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<SgSaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, SgBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgSaveBankAccountResponseModel,SgBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put, cancellationToken);
        }
    }
}
