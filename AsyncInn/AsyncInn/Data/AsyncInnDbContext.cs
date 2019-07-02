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
            ///Binding of Composite Keys
            modelBuilder.Entity<HotelRoom>().HasKey(hotelroom =>
            new { hotelroom.HotelID, hotelroom.RoomNumber });

            modelBuilder.Entity<RoomAmenities>().HasKey(roomamenity =>
            new { roomamenity.AmenitiesID, roomamenity.RoomID });

            /// Seed the Data
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Belltown",
                    StreetAddress = "2000 4th Ave",
                    City = "Seattle",
                    State = "Washington",
                    Phone = "(206) 448 - 8600"
                },

                new Hotel
                {
                    ID = 2,
                    Name = "North Congress",
                    StreetAddress = "101 Red River St",
                    City = "Austin",
                    State = "Texas",
                    Phone = "(512) 600-2000"
                },

                new Hotel
                {
                    ID = 3,
                    Name = "North Side",
                    StreetAddress = "11 E Walton St",
                    City = "Chicago",
                    State = "Illinois",
                    Phone = "(312) 646-1300"
                },

                new Hotel
                {
                    ID = 4,
                    Name = "Manhattan",
                    StreetAddress = "153 W 57th St",
                    City = "New York",
                    State = "New York",
                    Phone = "(646) 774-1234"
                },

                new Hotel
                {
                    ID = 5,
                    Name = "West Hollywood",
                    StreetAddress = "8221 Sunset Blvd",
                    City = "Los Angeles",
                    State = "California",
                    Phone = "(206) 448 - 8600"
                }
                );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Sauna"
                },

                new Amenities
                {
                    ID = 2,
                    Name = "Butler"
                },

                new Amenities
                {
                    ID = 3,
                    Name = "Chef"
                },

                new Amenities
                {
                    ID = 4,
                    Name = "Masseuse"
                },

                new Amenities
                {
                    ID = 5,
                    Name = "Theater Room"
                },

                new Amenities
                {
                    ID = 6,
                    Name = "Infinity Pool"
                }
                );


        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenitites { get; set; }

    }
}
