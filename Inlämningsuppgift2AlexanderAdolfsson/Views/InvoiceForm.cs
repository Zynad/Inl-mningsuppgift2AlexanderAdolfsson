using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class InvoiceForm : Form
    {
        AppManager manager = new AppManager();
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            AppManager.InvoiceExpires();
            FillInvoiceBox();
            FillInvoiceListbox();
        }

        private void ShowInvoiceBox_TextChanged(object sender, EventArgs e)
        {
            FillInvoiceListbox();
        }
        private void FillInvoiceBox()
        {
            ShowInvoiceBox.Items.Add("Alla fakturor");
            ShowInvoiceBox.Items.Add("Betalda fakturor");
            ShowInvoiceBox.Items.Add("Obetalda fakturor");
            ShowInvoiceBox.SelectedIndex = 0;
        }
        private void FillInvoiceListbox()
        {
            List<Invoice> sortedInvoiceList = manager.InvoiceHandlerList(ShowInvoiceBox.Text);
            InvoiceListbox.ValueMember = "InvoiceID";
            InvoiceListbox.DisplayMember = "InvoiceID";
            InvoiceListbox.DataSource = sortedInvoiceList;
        }

        private void InvoiceListbox_DoubleClick(object sender, EventArgs e)
        {
            InvoiceRepo repo = new InvoiceRepo();
            Invoice invoice = repo.GetInvoice(Convert.ToInt32(InvoiceListbox.SelectedValue));
            Booking booking = invoice.Booking.FirstOrDefault();
            InvoiceIDLabel.Text = $"Fakturanummer : {invoice.InvoiceID}";
            InvoiceIssueLabel.Text = $"Fakturadatum : {invoice.IssueDate.ToShortDateString()}";
            InvoiceExpireLabel.Text = $"Betalas senast : {invoice.ExpireDate.ToShortDateString()}";
            CustomerIDLabel.Text = $"Kundnummer : {booking.CustomerID}";
            CustomerMailLabel.Text = $"Kundens mail : {booking.Customer.Email}";
            BookingIDLabel.Text = $"BokningsNummer : {booking.BookingID}";
            if(invoice.IsPayed)
                InvoiceIsPayedCheckBox.Checked = true;
            else
                InvoiceIsPayedCheckBox.Checked = false;
        }

        private void UppdateInvoiceButton_Click(object sender, EventArgs e)
        {
            manager.UpdateInvoicePayed(Convert.ToInt32(InvoiceListbox.SelectedValue), InvoiceIsPayedCheckBox.Checked);
        }
    }
}
