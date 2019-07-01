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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(hotelroom =>
            new { hotelroom.HotelID, hotelroom.RoomNumber });

            modelBuilder.Entity<RoomAmenities>().HasKey(roomamenity =>
            new { roomamenity.AmenitiesID, roomamenity.RoomID });
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenitites { get; set; }

    }
}
