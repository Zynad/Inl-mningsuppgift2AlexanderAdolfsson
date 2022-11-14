﻿using Inlämningsuppgift2AlexanderAdolfsson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2AlexanderAdolfsson.Repository
{
    internal class RoomRepo
    {
        private HotelEntities _dbConnection;
        public RoomRepo()
        {
            _dbConnection = new HotelEntities();
        }
        public List<Room> GetAllRooms()
        {
            return _dbConnection.Rooms.ToList();
        }
    }
}
