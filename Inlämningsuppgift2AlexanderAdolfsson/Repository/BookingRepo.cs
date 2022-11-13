using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2AlexanderAdolfsson.Repository
{
    public class BookingRepo
    {
        private HotelEntities _dbConnection;
        public BookingRepo()
        {
            _dbConnection = new HotelEntities();
        }
        public List<Booking> GetAllBookings()
        {
            return _dbConnection.Booking.ToList();
        }
        public void InsertBooking(Booking booking)
        {
            _dbConnection.Booking.Add(booking);
            _dbConnection.SaveChanges();
        }
        public Booking GetBooking(int bookingID)
        {
            return _dbConnection.Booking.Find(bookingID);
        }

        public void DeleteBooking(int bookingID)
        {
            Booking booking = GetBooking(bookingID);
            _dbConnection.Booking.Remove(booking);
            _dbConnection.SaveChanges();
        }
        public void UpdateBooking(Booking booking)
        {
            Booking orgBooking = GetBooking(booking.BookingID);
            _dbConnection.Entry(orgBooking).CurrentValues.SetValues(booking);
            _dbConnection.SaveChanges();
        }
    }
}
