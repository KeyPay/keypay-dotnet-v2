using System;
using System.Collections.Generic;
using System.Linq;
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
            return ApiRequest<List<InvoiceModel>>($"/brand/{brandId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Get Brand Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBrandInvoiceById(int id, int brandId)
        {
            return ApiRequest<InvoiceModel>($"/brand/{brandId}/Invoice/{id}");
        }

        /// <summary>
        /// Get Brand Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoiceExcelById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/excel");
        }

        /// <summary>
        /// Get Brand Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Brand invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetBrandInvoicePdfById(int id, int brandId)
        {
            return ApiByteArrayRequest($"/brand/{brandId}/Invoice/{id}/pdf");
        }

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public List<InvoiceModel> GetBusinessInvoices(int businessId, GetBusinessInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/business/{businessId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Get Business Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetBusinessInvoiceById(int businessId, int id)
        {
            return ApiRequest<InvoiceModel>($"/business/{businessId}/Invoice/{id}");
        }

        /// <summary>
        /// Get Business Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Business invoice with the specified ID.
        /// </remarks>
        public byte[] GetBusinessInvoicePdfById(int businessId, int id)
        {
            return ApiByteArrayRequest($"/business/{businessId}/Invoice/{id}/pdf");
        }

        /// <summary>
        /// Get Reseller Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Reseller.
        /// </remarks>
        public List<InvoiceModel> GetResellerInvoices(int? resellerId, GetResellerInvoicesQueryModel request)
        {
            return ApiRequest<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Get Reseller Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetResellerInvoiceById(int resellerId, int id)
        {
            return ApiRequest<InvoiceModel>($"/reseller/{resellerId}/Invoice/{id}");
        }

        /// <summary>
        /// Get Reseller Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoiceExcelById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/excel");
        }

        /// <summary>
        /// Get Reseller Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the Reseller invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetResellerInvoicePdfById(int resellerId, int id)
        {
            return ApiByteArrayRequest($"/reseller/{resellerId}/Invoice/{id}/pdf");
        }
    }
}
