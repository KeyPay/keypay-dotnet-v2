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
using KeyPayV2.My.Models.Invoices;

namespace KeyPayV2.My.Functions
{
    public interface IInvoicesFunction
    {
        List<InvoiceModel> GetBrandInvoices(int brandId);
        Task<List<InvoiceModel>> GetBrandInvoicesAsync(int brandId, CancellationToken cancellationToken = default);
        List<InvoiceModel> GetBrandInvoices(int brandId, GetBrandInvoicesQueryModel request);
        Task<List<InvoiceModel>> GetBrandInvoicesAsync(int brandId, GetBrandInvoicesQueryModel request, CancellationToken cancellationToken = default);
        InvoiceModel GetBrandInvoiceById(int id, int brandId);
        Task<InvoiceModel> GetBrandInvoiceByIdAsync(int id, int brandId, CancellationToken cancellationToken = default);
        byte[] GetBrandInvoiceExcelById(int id, int brandId);
        Task<byte[]> GetBrandInvoiceExcelByIdAsync(int id, int brandId, CancellationToken cancellationToken = default);
        byte[] GetBrandInvoicePdfById(int id, int brandId);
        Task<byte[]> GetBrandInvoicePdfByIdAsync(int id, int brandId, CancellationToken cancellationToken = default);
        List<InvoiceModel> GetBusinessInvoices(int businessId);
        Task<List<InvoiceModel>> GetBusinessInvoicesAsync(int businessId, CancellationToken cancellationToken = default);
        List<InvoiceModel> GetBusinessInvoices(int businessId, GetBusinessInvoicesQueryModel request);
        Task<List<InvoiceModel>> GetBusinessInvoicesAsync(int businessId, GetBusinessInvoicesQueryModel request, CancellationToken cancellationToken = default);
        InvoiceModel GetBusinessInvoiceById(int businessId, int id);
        Task<InvoiceModel> GetBusinessInvoiceByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        byte[] GetBusinessInvoicePdfById(int businessId, int id);
        Task<byte[]> GetBusinessInvoicePdfByIdAsync(int businessId, int id, CancellationToken cancellationToken = default);
        List<InvoiceModel> GetResellerInvoices(int? resellerId);
        Task<List<InvoiceModel>> GetResellerInvoicesAsync(int? resellerId, CancellationToken cancellationToken = default);
        List<InvoiceModel> GetResellerInvoices(int? resellerId, GetResellerInvoicesQueryModel request);
        Task<List<InvoiceModel>> GetResellerInvoicesAsync(int? resellerId, GetResellerInvoicesQueryModel request, CancellationToken cancellationToken = default);
        InvoiceModel GetResellerInvoiceById(int resellerId, int id);
        Task<InvoiceModel> GetResellerInvoiceByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default);
        byte[] GetResellerInvoiceExcelById(int resellerId, int id);
        Task<byte[]> GetResellerInvoiceExcelByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default);
        byte[] GetResellerInvoicePdfById(int resellerId, int id);
        Task<byte[]> GetResellerInvoicePdfByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default);
    }
    public class InvoicesFunction : BaseFunction, IInvoicesFunction
    {
        public InvoicesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public List<InvoiceModel> GetBrandInvoices(int brandId)
        {
            return ApiRequest<List<InvoiceModel>>($"/brand/{brandId}/Invoice", Method.Get);
        }

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBrandInvoicesAsync(int brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/brand/{brandId}/Invoice", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public List<InvoiceModel> GetBrandInvoices(int brandId, GetBrandInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/brand/{brandId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBrandInvoicesAsync(int brandId, GetBrandInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/brand/{brandId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBrandInvoiceById(int id, int brandId)
        {
            return ApiRequest<InvoiceModel>($"/brand/{brandId}/Invoice/{id}", Method.Get);
        }

        /// <summary>
        /// Get Brand Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetBrandInvoiceByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/brand/{brandId}/Invoice/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoiceExcelById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/excel", Method.Get);
        }

        /// <summary>
        /// Get Brand Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice Excel with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBrandInvoiceExcelByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/brand/{brandId}/Invoice/{id}/excel", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoicePdfById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/pdf", Method.Get);
        }

        /// <summary>
        /// Get Brand Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice PDF with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBrandInvoicePdfByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/brand/{brandId}/Invoice/{id}/pdf", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public List<InvoiceModel> GetBusinessInvoices(int businessId)
        {
            return ApiRequest<List<InvoiceModel>>($"/business/{businessId}/Invoice", Method.Get);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBusinessInvoicesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/business/{businessId}/Invoice", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public List<InvoiceModel> GetBusinessInvoices(int businessId, GetBusinessInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/business/{businessId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBusinessInvoicesAsync(int businessId, GetBusinessInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/business/{businessId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBusinessInvoiceById(int businessId, int id)
        {
            return ApiRequest<InvoiceModel>($"/business/{businessId}/Invoice/{id}", Method.Get);
        }

        /// <summary>
        /// Get Business Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetBusinessInvoiceByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/business/{businessId}/Invoice/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public byte[] GetBusinessInvoicePdfById(int businessId, int id)
        {
            return ApiByteArrayRequest($"/business/{businessId}/Invoice/{id}/pdf", Method.Get);
        }

        /// <summary>
        /// Get Business Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBusinessInvoicePdfByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/Invoice/{id}/pdf", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public List<InvoiceModel> GetResellerInvoices(int? resellerId)
        {
            return ApiRequest<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice", Method.Get);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public Task<List<InvoiceModel>> GetResellerInvoicesAsync(int? resellerId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public List<InvoiceModel> GetResellerInvoices(int? resellerId, GetResellerInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public Task<List<InvoiceModel>> GetResellerInvoicesAsync(int? resellerId, GetResellerInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetResellerInvoiceById(int resellerId, int id)
        {
            return ApiRequest<InvoiceModel>($"/reseller/{resellerId}/Invoice/{id}", Method.Get);
        }

        /// <summary>
        /// Get Reseller Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetResellerInvoiceByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/reseller/{resellerId}/Invoice/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoiceExcelById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/excel", Method.Get);
        }

        /// <summary>
        /// Get Reseller Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice Excel with the specified ID.
        /// </remarks>
        public Task<byte[]> GetResellerInvoiceExcelByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/reseller/{resellerId}/Invoice/{id}/excel", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoicePdfById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/pdf", Method.Get);
        }

        /// <summary>
        /// Get Reseller Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice PDF with the specified ID.
        /// </remarks>
        public Task<byte[]> GetResellerInvoicePdfByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/reseller/{resellerId}/Invoice/{id}/pdf", Method.Get, cancellationToken);
        }
    }
}
