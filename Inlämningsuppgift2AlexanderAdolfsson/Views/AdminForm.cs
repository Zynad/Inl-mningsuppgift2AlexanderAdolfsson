using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using System;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class AdminForm : Form
    {
        AppManager manager = new AppManager();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            manager.OpenCustomerForm();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            manager.OpenBookingForm();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            manager.OpenInvoiceForm();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AppManager.InvoiceExpires();
        }

        private void HandleBookingButton_Click(object sender, EventArgs e)
        {
            manager.OpenHandleBookingForm();
        }
    }
}
