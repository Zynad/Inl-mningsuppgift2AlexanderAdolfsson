using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _dbConnection.Invoice.ToList();
        }
        public Invoice GetInvoice(int invoiceID)
        {
            return _dbConnection.Invoice.Find(invoiceID);
        }

        public void InsertInvoice(Invoice invoice)
        {
            _dbConnection.Invoice.Add(invoice);
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
            _dbConnection.Invoice.Remove(invoice);
            _dbConnection.SaveChanges();
        }

    }
}
