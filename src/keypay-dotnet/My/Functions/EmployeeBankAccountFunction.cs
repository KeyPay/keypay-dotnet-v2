using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.EmployeeBankAccount;

namespace KeyPayV2.My.Functions
{
    public interface IEmployeeBankAccountFunction
    {
        List<MyBankAccountModel> ListBankAccounts(int businessId, int employeeId);
        Task<List<MyBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default);
        MySaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, MyBankAccountModel model);
        Task<MySaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, MyBankAccountModel model, CancellationToken cancellationToken = default);
        MyBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId);
        Task<MyBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        MySaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId);
        Task<MySaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default);
        MySaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, MyBankAccountModel model);
        Task<MySaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, MyBankAccountModel model, CancellationToken cancellationToken = default);
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
        public List<MyBankAccountModel> ListBankAccounts(int businessId, int employeeId)
        {
            return ApiRequest<List<MyBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<MyBankAccountModel>> ListBankAccountsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBankAccountModel>>($"/business/{businessId}/employee/{employeeId}/bankaccount", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public MySaveBankAccountResponseModel CreateBankAccount(int businessId, int employeeId, MyBankAccountModel model)
        {
            return ApiRequest<MySaveBankAccountResponseModel,MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<MySaveBankAccountResponseModel> CreateBankAccountAsync(int businessId, int employeeId, MyBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MySaveBankAccountResponseModel,MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public MyBankAccountModel GetBankAccountById(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<MyBankAccountModel> GetBankAccountByIdAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public MySaveBankAccountResponseModel DeleteBankAccount(int businessId, int employeeId, int bankAccountId)
        {
            return ApiRequest<MySaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<MySaveBankAccountResponseModel> DeleteBankAccountAsync(int businessId, int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MySaveBankAccountResponseModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{bankAccountId}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public MySaveBankAccountResponseModel UpdateBankAccount(int businessId, int employeeId, int id, MyBankAccountModel model)
        {
            return ApiRequest<MySaveBankAccountResponseModel,MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<MySaveBankAccountResponseModel> UpdateBankAccountAsync(int businessId, int employeeId, int id, MyBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MySaveBankAccountResponseModel,MyBankAccountModel>($"/business/{businessId}/employee/{employeeId}/bankaccount/{id}", model, Method.Put, cancellationToken);
        }
    }
}
