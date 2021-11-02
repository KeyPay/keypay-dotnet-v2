using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Invoices;

namespace KeyPayV2.Uk.Functions
{
    public class InvoicesFunction : BaseFunction
    {
        public InvoicesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public List<InvoiceModel> GetBrandInvoices(int brandId, GetBrandInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/brand/{brandId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Brand Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Brand.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBrandInvoicesAsync(int brandId, GetBrandInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/brand/{brandId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBrandInvoiceById(int id, int brandId)
        {
            return ApiRequest<InvoiceModel>($"/brand/{brandId}/Invoice/{id}", Method.GET);
        }

        /// <summary>
        /// Get Brand Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetBrandInvoiceByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/brand/{brandId}/Invoice/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoiceExcelById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/excel", Method.GET);
        }

        /// <summary>
        /// Get Brand Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice Excel with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBrandInvoiceExcelByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/brand/{brandId}/Invoice/{id}/excel", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Brand Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoicePdfById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/pdf", Method.GET);
        }

        /// <summary>
        /// Get Brand Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice PDF with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBrandInvoicePdfByIdAsync(int id, int brandId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/brand/{brandId}/Invoice/{id}/pdf", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public List<InvoiceModel> GetBusinessInvoices(int businessId, GetBusinessInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/business/{businessId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public Task<List<InvoiceModel>> GetBusinessInvoicesAsync(int businessId, GetBusinessInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/business/{businessId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBusinessInvoiceById(int businessId, int id)
        {
            return ApiRequest<InvoiceModel>($"/business/{businessId}/Invoice/{id}", Method.GET);
        }

        /// <summary>
        /// Get Business Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetBusinessInvoiceByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/business/{businessId}/Invoice/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Business Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public byte[] GetBusinessInvoicePdfById(int businessId, int id)
        {
            return ApiByteArrayRequest($"/business/{businessId}/Invoice/{id}/pdf", Method.GET);
        }

        /// <summary>
        /// Get Business Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public Task<byte[]> GetBusinessInvoicePdfByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/Invoice/{id}/pdf", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public List<InvoiceModel> GetResellerInvoices(int? resellerId, GetResellerInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public Task<List<InvoiceModel>> GetResellerInvoicesAsync(int? resellerId, GetResellerInvoicesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetResellerInvoiceById(int resellerId, int id)
        {
            return ApiRequest<InvoiceModel>($"/reseller/{resellerId}/Invoice/{id}", Method.GET);
        }

        /// <summary>
        /// Get Reseller Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice with the specified ID.
        /// </remarks>
        public Task<InvoiceModel> GetResellerInvoiceByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<InvoiceModel>($"/reseller/{resellerId}/Invoice/{id}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoiceExcelById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/excel", Method.GET);
        }

        /// <summary>
        /// Get Reseller Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice Excel with the specified ID.
        /// </remarks>
        public Task<byte[]> GetResellerInvoiceExcelByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/reseller/{resellerId}/Invoice/{id}/excel", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Reseller Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoicePdfById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/pdf", Method.GET);
        }

        /// <summary>
        /// Get Reseller Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice PDF with the specified ID.
        /// </remarks>
        public Task<byte[]> GetResellerInvoicePdfByIdAsync(int resellerId, int id, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/reseller/{resellerId}/Invoice/{id}/pdf", Method.GET, cancellationToken);
        }
    }
}
