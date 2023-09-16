using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrderColumInStatusTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "STATUSES",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StatusID",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApplyForDiscount",
                table: "ORDERS",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryId",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ORDERS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS",
                column: "StatusID",
                principalTable: "STATUSES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "STATUSES");

            migrationBuilder.DropColumn(
                name: "ApplyForDiscount",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ORDERS");

            migrationBuilder.AlterColumn<Guid>(
                name: "StatusID",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS",
                column: "StatusID",
                principalTable: "STATUSES",
                principalColumn: "Id");
        }
    }
}
