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
    public partial class BookingForm : Form
    {
        DateTime startDate;
        DateTime endDate;
        int customerID;
        int roomID;
        int noOfPersons;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void NewBookingButton_Click(object sender, EventArgs e)
        {
            customerID = Convert.ToInt32(CustomerList.SelectedValue);
            roomID = Convert.ToInt32(RoomList.SelectedValue);
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDate = Convert.ToDateTime(StartDatePicker.Text);
            
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDate = Convert.ToDateTime(EndDatePicker.Text);
            
        }

        private void NoOfPersonBox_TextChanged(object sender, EventArgs e)
        {
            noOfPersons = int.Parse(NoOfPersonBox.Text);
            FillRoomsList();
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
            List<Room> roomlist = manager.AvailableRooms(startDate,endDate,noOfPersons);
            RoomList.ValueMember = "RoomID";
            RoomList.DisplayMember = "Name";
            RoomList.DataSource = roomlist;
        }
        private void FillPersonBox()
        {
            NoOfPersonBox.Items.Add("1");
            NoOfPersonBox.Items.Add("2");
            NoOfPersonBox.Items.Add("3");
            NoOfPersonBox.Items.Add("4");
            NoOfPersonBox.Text = "1";
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            FillPersonBox();
            FillRoomsList();
            FillCustomersList();
        }
    }
}
