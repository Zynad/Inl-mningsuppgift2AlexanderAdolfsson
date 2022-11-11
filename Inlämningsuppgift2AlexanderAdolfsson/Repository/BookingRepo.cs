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
    }
}
