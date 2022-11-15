using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class UpdateBookingForm : Form
    {
        AppManager manager = new AppManager();
        Booking selectedBooking;
        public int BookingID { get; set; }
        public UpdateBookingForm(int bookingID)
        {
            InitializeComponent();
            BookingID = bookingID;
        }

        private void UpdateBookingForm_Load(object sender, EventArgs e)
        {
            FillNoOfPersonsBox();
            FillLabelsAndBoxes();
        }
        private void FillNoOfPersonsBox()
        {
            NoOfPersonsBox.Items.Add("1");
            NoOfPersonsBox.Items.Add("2");
            NoOfPersonsBox.Items.Add("3");
            NoOfPersonsBox.Items.Add("4");
        }
        private void FillLabelsAndBoxes()
        {
            BookingRepo repo = new BookingRepo();
            selectedBooking = repo.GetBooking(BookingID);
            BookingIDLabel.Text = $"Bokningsnummer : {selectedBooking.BookingID}";
            CustomerIDLabel.Text = $"Kundnummer : {selectedBooking.CustomerID}";
            CustomerNameLabel.Text = $"Kundnamn : {selectedBooking.Customer.Name}";
            CustomerMailLabel.Text = $"Kundens mail : {selectedBooking.Customer.Email}";
            NoOfPersonsBox.Text = selectedBooking.NoOfPersons.ToString();
            StartDatePicker.Value = selectedBooking.StartDate;
            EndDatePicker.Value = selectedBooking.EndDate;
            FillRoomList();
            RoomNumberBox.Text = selectedBooking.Room.Name;         
            RoomTypeNameLabel.Text = $"Rumstyp : {selectedBooking.Room.RoomType.Name}";
            if (selectedBooking.Invoice.IsPayed)
                InvoiceIsPayedLabel.Text = "Är fakturan betald : Ja";
            else
                InvoiceIsPayedLabel.Text = "Är fakturan betald : Nej";
        }
        private void FillRoomList()
        {
            List<Room> availableRooms = manager.AvailableRooms(Convert.ToDateTime(StartDatePicker.Text), Convert.ToDateTime(EndDatePicker.Text), int.Parse(NoOfPersonsBox.Text));
            RoomNumberBox.ValueMember = "RoomID";
            RoomNumberBox.DisplayMember = "Name";
            RoomNumberBox.DataSource = availableRooms;
        }

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {
            FillRoomList();
        }

        private void UpdateBookingButton_Click(object sender, EventArgs e)
        {
            BookingRepo repo = new BookingRepo();
            selectedBooking.StartDate = Convert.ToDateTime(StartDatePicker.Text);
            selectedBooking.EndDate = Convert.ToDateTime(EndDatePicker.Text);
            selectedBooking.NoOfPersons = int.Parse(NoOfPersonsBox.Text);
            if(RoomNumberBox.Text == selectedBooking.Room.Name)
                repo.UpdateBooking(selectedBooking);
            else
            {
                selectedBooking.RoomID = Convert.ToInt32(RoomNumberBox.SelectedValue);
                repo.UpdateBooking(selectedBooking);
            }
            MessageBox.Show("Din bokning är uppdaterad");
        }

        private void RemoveBookingButton_Click(object sender, EventArgs e)
        {
            BookingRepo bookingRepo = new BookingRepo();
            InvoiceRepo invoiceRepo = new InvoiceRepo();
            bookingRepo.DeleteBooking(selectedBooking.BookingID);
            invoiceRepo.DeleteInvoice(selectedBooking.InvoiceID);
            MessageBox.Show("Bokning samt faktura är borttagna");
            this.Close();
        }
    }
    
}
