using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AsyncInn.Data
{
    public class AsyncInnDBContext: DbContext
    {
        public AsyncInnDBContext(DbContextOptions<AsyncInnDBContext> options) : base 
            (options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenitites { get; set; }


    }
}
