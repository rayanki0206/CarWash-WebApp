using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShineNDrive.Migrations
{
    /// <inheritdoc />
    public partial class dbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "BookingInfos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BookingInfos");

            migrationBuilder.DropColumn(
                name: "District",
                table: "BookingInfos");

            migrationBuilder.DropColumn(
                name: "DoorNo",
                table: "BookingInfos");

            migrationBuilder.DropColumn(
                name: "Landmark",
                table: "BookingInfos");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "DoorNo",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Landmark",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Services",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "BookingInfos",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Admins",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Services",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "BookingInfos",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Admins",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoorNo",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Landmark",
                table: "BookingInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoorNo",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Landmark",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
