using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class CustomerForm : Form
    {
        AppManager manager = new AppManager();
        int currentCustomer = 0;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            manager.TryCustomerAdd(CustomerNameText.Text, CustomerEmailText.Text, CustomerPhoneText.Text);
            UpdateForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            manager.TryCustomerUpdate(currentCustomer, CustomerNameText.Text, CustomerEmailText.Text, CustomerPhoneText.Text);
            UpdateForm();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            manager.TryCustomerDelete(currentCustomer);
            UpdateForm();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
            AppManager.InvoiceExpires();
        }
        private void CustomerList_DoubleClick(object sender, EventArgs e)
        {
            Customer selectedCustomer = AppManager.ShowCustomer(Convert.ToInt32(CustomerList.SelectedValue));
            CustomerIDLabel.Text = $"Kundnummer : {selectedCustomer.CustomerID}";
            currentCustomer = selectedCustomer.CustomerID;
            CustomerNameText.Text = selectedCustomer.Name;
            CustomerEmailText.Text = selectedCustomer.Email;
            CustomerPhoneText.Text = selectedCustomer.Phone;
        }
        private void FillCustomersList()
        {
            CustomerRepo repo = new CustomerRepo();
            List<Customer> customerList = repo.GetAllCustomers();
            CustomerList.ValueMember = "CustomerID";
            CustomerList.DisplayMember = "Name";
            CustomerList.DataSource = customerList;
        }
        private void UpdateForm()
        {
            CustomerIDLabel.Text = "Kundnummer :";
            currentCustomer = 0;
            CustomerNameText.Text = "";
            CustomerEmailText.Text = "";
            CustomerPhoneText.Text = "";
            FillCustomersList();
        }


    }
}
