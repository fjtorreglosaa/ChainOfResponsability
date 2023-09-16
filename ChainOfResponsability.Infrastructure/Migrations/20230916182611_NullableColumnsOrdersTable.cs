using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NullableColumnsOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "StatusID",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerReference",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS",
                column: "StatusID",
                principalTable: "STATUSES",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StatusID",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerReference",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS",
                column: "StatusID",
                principalTable: "STATUSES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
