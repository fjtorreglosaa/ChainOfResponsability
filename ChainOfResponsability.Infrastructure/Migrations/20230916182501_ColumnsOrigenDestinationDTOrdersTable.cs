using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ColumnsOrigenDestinationDTOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chain",
                table: "ORDERS");

            migrationBuilder.AddColumn<decimal>(
                name: "DeliveryTime",
                table: "ORDERS",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origen",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "Origen",
                table: "ORDERS");

            migrationBuilder.AddColumn<string>(
                name: "Chain",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
