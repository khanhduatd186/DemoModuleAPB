using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoModule.Migrations
{
    /// <inheritdoc />
    public partial class createcustomerandcountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemoModuleCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemoModuleCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DemoModuleCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemoModuleCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DemoModuleCustomers_DemoModuleCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "DemoModuleCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemoModuleCustomers_CountryId",
                table: "DemoModuleCustomers",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemoModuleCustomers");

            migrationBuilder.DropTable(
                name: "DemoModuleCountries");
        }
    }
}
