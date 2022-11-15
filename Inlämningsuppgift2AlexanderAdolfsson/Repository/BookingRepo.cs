using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System.Collections.Generic;
using System.Linq;

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
            return _dbConnection.Bookings.ToList();
        }
        public void InsertBooking(Booking booking)
        {
            _dbConnection.Bookings.Add(booking);
            _dbConnection.SaveChanges();
        }
        public Booking GetBooking(int bookingID)
        {
            return _dbConnection.Bookings.Find(bookingID);
        }

        public void DeleteBooking(int bookingID)
        {
            Booking booking = GetBooking(bookingID);
            _dbConnection.Bookings.Remove(booking);
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
