using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserIdInOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "STATUSES");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "ORDERS");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "ITEMS");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "INVOICES");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "ORDER_ITEMS");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "ORDER_ITEMS",
                newName: "IX_ORDER_ITEMS_OrderId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ORDERS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATUSES",
                table: "STATUSES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ORDERS",
                table: "ORDERS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMS",
                table: "ITEMS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_INVOICES",
                table: "INVOICES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ORDER_ITEMS",
                table: "ORDER_ITEMS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS",
                column: "OrderId",
                principalTable: "ORDERS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_STATUSES",
                table: "STATUSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ORDERS",
                table: "ORDERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMS",
                table: "ITEMS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICES",
                table: "INVOICES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ORDER_ITEMS",
                table: "ORDER_ITEMS");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ORDERS");

            migrationBuilder.RenameTable(
                name: "STATUSES",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "ORDERS",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "ITEMS",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "INVOICES",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "ORDER_ITEMS",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_ORDER_ITEMS_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
