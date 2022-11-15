using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using Inlämningsuppgift2AlexanderAdolfsson.Models;
using Inlämningsuppgift2AlexanderAdolfsson.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class HandleBookingForm : Form
    {
        public HandleBookingForm()
        {
            InitializeComponent();
        }

        private void HandleBookingForm_Load(object sender, EventArgs e)
        {
            AppManager.InvoiceExpires();
            FillGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AppManager manager = new AppManager();
            manager.OpenUpdateBookingForm(Convert.ToInt32(BookingGrid.SelectedRows[0].Cells[0].Value));
            this.Close();
        }

        private void FillGridView()
        {
            BookingRepo repo = new BookingRepo();
            List<Booking> allBookings = repo.GetAllBookings();
            foreach (Booking booking in allBookings)
            {
                BookingGrid.Rows.Add(booking.BookingID,
                    booking.Customer.Name,
                    booking.Room.Name,
                    booking.StartDate.ToShortDateString(),
                    booking.EndDate.ToShortDateString(),
                    booking.Invoice.IsPayed);
            }
        }
    }
}
