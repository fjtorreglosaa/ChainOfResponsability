using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ColumnChainAddedToOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chain",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chain",
                table: "ORDERS");
        }
    }
}
