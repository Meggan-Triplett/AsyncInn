using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Layout = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HotelRooms",
                columns: table => new
                {
                    HotelID = table.Column<int>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    PetFriendly = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRooms", x => new { x.HotelID, x.RoomNumber });
                    table.ForeignKey(
                        name: "FK_HotelRooms_Hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelRooms_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomAmenitites",
                columns: table => new
                {
                    AmenitiesID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenitites", x => new { x.AmenitiesID, x.RoomID });
                    table.ForeignKey(
                        name: "FK_RoomAmenitites_Amenities_AmenitiesID",
                        column: x => x.AmenitiesID,
                        principalTable: "Amenities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomAmenitites_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Sauna" },
                    { 2, "Butler" },
                    { 3, "Chef" },
                    { 4, "Masseuse" },
                    { 5, "Theater Room" },
                    { 6, "Infinity Pool" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Seattle", "Belltown", "(206) 448 - 8600", "Washington", "2000 4th Ave" },
                    { 2, "Austin", "North Congress", "(512) 600-2000", "Texas", "101 Red River St" },
                    { 3, "Chicago", "North Side", "(312) 646-1300", "Illinois", "11 E Walton St" },
                    { 4, "New York", "Manhattan", "(646) 774-1234", "New York", "153 W 57th St" },
                    { 5, "Los Angeles", "West Hollywood", "(206) 448 - 8600", "California", "8221 Sunset Blvd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenitites_RoomID",
                table: "RoomAmenitites",
                column: "RoomID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelRooms");

            migrationBuilder.DropTable(
                name: "RoomAmenitites");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
