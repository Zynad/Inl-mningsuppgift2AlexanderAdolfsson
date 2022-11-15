using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift2AlexanderAdolfsson.Repository
{
    public class InvoiceRepo
    {
        private HotelEntities _dbConnection;

        public InvoiceRepo()
        {
            _dbConnection = new HotelEntities();
        }
        public List<Invoice> GetAllInvoice()
        {
            return _dbConnection.Invoices.ToList();
        }
        public Invoice GetInvoice(int invoiceID)
        {
            return _dbConnection.Invoices.Find(invoiceID);
        }

        public void InsertInvoice(Invoice invoice)
        {
            _dbConnection.Invoices.Add(invoice);
            _dbConnection.SaveChanges();
        }
        public void UpdateInvoice(Invoice invoice)
        {
            Invoice orgInvoice = GetInvoice(invoice.InvoiceID);
            _dbConnection.Entry(orgInvoice).CurrentValues.SetValues(invoice);
            _dbConnection.SaveChanges();
        }
        public void DeleteInvoice(int invoiceID)
        {
            Invoice invoice = GetInvoice(invoiceID);
            _dbConnection.Invoices.Remove(invoice);
            _dbConnection.SaveChanges();
        }

    }
}
