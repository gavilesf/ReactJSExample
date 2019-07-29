using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalWeb.Migrations
{
    public partial class AddVehicleTableFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileUrl",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileUrl",
                table: "Vehicles");
        }
    }
}
