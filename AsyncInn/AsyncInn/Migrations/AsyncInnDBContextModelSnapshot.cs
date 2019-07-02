﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDBContext))]
    partial class AsyncInnDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Sauna"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Butler"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Chef"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Masseuse"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Theater Room"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Infinity Pool"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Seattle",
                            Name = "Belltown",
                            Phone = "(206) 448 - 8600",
                            State = "Washington",
                            StreetAddress = "2000 4th Ave"
                        },
                        new
                        {
                            ID = 2,
                            City = "Austin",
                            Name = "North Congress",
                            Phone = "(512) 600-2000",
                            State = "Texas",
                            StreetAddress = "101 Red River St"
                        },
                        new
                        {
                            ID = 3,
                            City = "Chicago",
                            Name = "North Side",
                            Phone = "(312) 646-1300",
                            State = "Illinois",
                            StreetAddress = "11 E Walton St"
                        },
                        new
                        {
                            ID = 4,
                            City = "New York",
                            Name = "Manhattan",
                            Phone = "(646) 774-1234",
                            State = "New York",
                            StreetAddress = "153 W 57th St"
                        },
                        new
                        {
                            ID = 5,
                            City = "Los Angeles",
                            Name = "West Hollywood",
                            Phone = "(206) 448 - 8600",
                            State = "California",
                            StreetAddress = "8221 Sunset Blvd"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<byte>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomID");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenitites");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
