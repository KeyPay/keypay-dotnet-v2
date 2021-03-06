using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Invoices;

namespace KeyPayV2.Au.Functions
{
    public class InvoicesFunction : BaseFunction
    {
        public InvoicesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Business Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified Business.
        /// </remarks>
        public List<InvoiceModel> GetBusinessInvoices(int businessId)
        {
            return ApiRequest<List<InvoiceModel>>($"/business/{businessId}/Invoice");
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
        public List<InvoiceModel> GetResellerInvoices(int? resellerId)
        {
            return ApiRequest<List<InvoiceModel>>($"/reseller/{resellerId}/Invoice");
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
        /// Get White Label Invoices
        /// </summary>
        /// <remarks>
        /// Get invoices for the specified White Label.
        /// </remarks>
        public List<InvoiceModel> GetWhiteLabelInvoices(int whiteLabelId)
        {
            return ApiRequest<List<InvoiceModel>>($"/whitelabel/{whiteLabelId}/Invoice");
        }

        /// <summary>
        /// Get White Label Invoice By ID
        /// </summary>
        /// <remarks>
        /// Gets the White lanel invoice with the specified ID.
        /// </remarks>
        public InvoiceModel GetWhiteLabelInvoiceById(int whiteLabelId, int id)
        {
            return ApiRequest<InvoiceModel>($"/whitelabel/{whiteLabelId}/Invoice/{id}");
        }

        /// <summary>
        /// Get White Label Invoice Excel By ID
        /// </summary>
        /// <remarks>
        /// Gets the White Label invoice Excel with the specified ID.
        /// </remarks>
        public byte[] GetWhiteLabelInvoiceExcelById(int whiteLabelId, int id)
        {
            return ApiByteArrayRequest($"/whitelabel/{whiteLabelId}/Invoice/{id}/excel");
        }

        /// <summary>
        /// Get White Label Invoice PDF By ID
        /// </summary>
        /// <remarks>
        /// Gets the White Label invoice PDF with the specified ID.
        /// </remarks>
        public byte[] GetWhiteLabelInvoicePdfById(int whiteLabelId, int id)
        {
            return ApiByteArrayRequest($"/whitelabel/{whiteLabelId}/Invoice/{id}/pdf");
        }
    }
}
