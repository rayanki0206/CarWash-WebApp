using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShineNDrive.Migrations
{
    /// <inheritdoc />
    public partial class ServiceTypeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "BookingInfos");
        }
    }
}
