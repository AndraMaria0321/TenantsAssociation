using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Apartment_ApartmentId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "Invoice",
                newName: "ApartmenTId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ApartmentId",
                table: "Invoice",
                newName: "IX_Invoice_ApartmenTId");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmenTId",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Apartment_ApartmenTId",
                table: "Invoice",
                column: "ApartmenTId",
                principalTable: "Apartment",
                principalColumn: "ApartmenTId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Apartment_ApartmenTId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "ApartmenTId",
                table: "Invoice",
                newName: "ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_ApartmenTId",
                table: "Invoice",
                newName: "IX_Invoice_ApartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "Invoice",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Apartment_ApartmentId",
                table: "Invoice",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "ApartmenTId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
