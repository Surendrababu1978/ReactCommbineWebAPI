using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineCustomerMerchant.Migrations
{
    /// <inheritdoc />
    public partial class Revised : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Customer",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    MerchantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GSTNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AAdhaarNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MapPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantID", x => x.MerchantID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
