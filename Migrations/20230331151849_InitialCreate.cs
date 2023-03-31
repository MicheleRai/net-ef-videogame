using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoftwareHouse",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iva = table.Column<long>(type: "bigint", nullable: false),
                    Citta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paese = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "videogames",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUscita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftwareHouseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videogames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_videogames_SoftwareHouse_SoftwareHouseId",
                        column: x => x.SoftwareHouseId,
                        principalTable: "SoftwareHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_videogames_Id",
                table: "videogames",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_videogames_SoftwareHouseId",
                table: "videogames",
                column: "SoftwareHouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "videogames");

            migrationBuilder.DropTable(
                name: "SoftwareHouse");
        }
    }
}
