using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ColumnChainAddedToStatusesTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chain",
                table: "STATUSES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chain",
                table: "STATUSES");
        }
    }
}
