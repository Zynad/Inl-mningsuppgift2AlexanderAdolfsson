using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class BookingForm : Form
    {
        int customerID = 0;
        int roomID = 0;
        int noOfPersons = 1;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void NewBookingButton_Click(object sender, EventArgs e)
        {
            customerID = Convert.ToInt32(CustomerList.SelectedValue);
            roomID = Convert.ToInt32(RoomList.SelectedValue);
            if (roomID == 0 || customerID == 0 || StartDatePicker.Text == EndDatePicker.Text)
                MessageBox.Show("Du måste välja en kund, ett rum och korrekta datum");
            else
            {
                AppManager manager = new AppManager();
                manager.CreateBooking(customerID,roomID, Convert.ToDateTime(StartDatePicker.Text), Convert.ToDateTime(EndDatePicker.Text),int.Parse(NoOfPersonBox.Text));
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            FillPersonBox();
            AppManager.InvoiceExpires();
        }
        private void FillPersonBox()
        {
            NoOfPersonBox.Items.Add("1");
            NoOfPersonBox.Items.Add("2");
            NoOfPersonBox.Items.Add("3");
            NoOfPersonBox.Items.Add("4");
            NoOfPersonBox.Text = "1";
        }

        private void NoOfPersonBox_TextChanged(object sender, EventArgs e)
        {
            noOfPersons = int.Parse(NoOfPersonBox.Text);
        }

        private void CustomerSearchText_TextChanged(object sender, EventArgs e)
        {
            FillCustomersList();
        }
        private void FillCustomersList()
        {
            CustomerRepo repo = new CustomerRepo();
            List<Customer> customerList = repo.GetAllCustomers(CustomerSearchText.Text);
            CustomerList.ValueMember = "CustomerID";
            CustomerList.DisplayMember = "Name";
            CustomerList.DataSource = customerList;
        }
        private void FillRoomsList()
        {
            AppManager manager = new AppManager();
            List<Room> roomlist = manager.AvailableRooms(Convert.ToDateTime(StartDatePicker.Text), Convert.ToDateTime(EndDatePicker.Text), noOfPersons);
            RoomList.ValueMember = "RoomID";
            RoomList.DisplayMember = "Name";
            RoomList.DataSource = roomlist;
        }

        private void SearchRoomButton_Click(object sender, EventArgs e)
        {
            FillRoomsList();
        }
    }
}
