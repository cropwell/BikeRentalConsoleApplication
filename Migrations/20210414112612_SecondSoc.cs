using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class SecondSoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CustomerInformation_BookingId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "CustomerInformation");

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SocialSecurityNumber",
                table: "Bookings",
                column: "SocialSecurityNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CustomerInformation_SocialSecurityNumber",
                table: "Bookings",
                column: "SocialSecurityNumber",
                principalTable: "CustomerInformation",
                principalColumn: "SocialSecurityNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CustomerInformation_SocialSecurityNumber",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SocialSecurityNumber",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "BookingId",
                table: "CustomerInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CustomerInformation_BookingId",
                table: "Bookings",
                column: "BookingId",
                principalTable: "CustomerInformation",
                principalColumn: "SocialSecurityNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
