using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    AlbumArtUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 1, "Panic at the Disco" },
                    { 2, "Imagine Dragons" },
                    { 3, "Greta Van Fleet" },
                    { 4, "Twenty One Pilots" },
                    { 5, "Rolling Stones" },
                    { 6, "Led Zepplin" },
                    { 7, "Cheap Trick" },
                    { 8, "Pink" },
                    { 9, "Bob Marley and the Wailers" },
                    { 10, "Fleetwood Mac" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 11, null, "R&B/Soul" },
                    { 10, null, "Pop" },
                    { 9, null, "Metal" },
                    { 8, null, "Jazz" },
                    { 7, null, "Hip Hop" },
                    { 2, null, "Blues" },
                    { 5, null, "Dance" },
                    { 4, null, "Country" },
                    { 3, null, "Classical" },
                    { 12, null, "Raggae" },
                    { 1, null, "Alternative" },
                    { 6, null, "Electronic" },
                    { 13, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "", 1, 1, 9.99m, "Pray for the Wicked" },
                    { 2, "", 1, 1, 7.99m, "Death of a Bachelor" },
                    { 3, "", 2, 1, 11.99m, "Origins" },
                    { 4, "", 2, 1, 9.99m, "Evolve" },
                    { 9, "", 9, 12, 9.99m, "Legend" },
                    { 10, "", 9, 12, 7.99m, "Exodus" },
                    { 5, "", 3, 13, 6.99m, "From the Fires" },
                    { 6, "", 3, 13, 6.99m, "Anthem of the Peaceful Army" },
                    { 7, "", 5, 13, 14.99m, "Hot Rocks 1964-1971" },
                    { 8, "", 10, 13, 6.99m, "Rumours" },
                    { 11, "", 7, 13, 10.99m, "Authorized Greatest Hits" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
