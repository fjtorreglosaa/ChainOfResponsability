using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "ORDER_ITEMS",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_StatusID",
                table: "ORDERS",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_ItemId",
                table: "ORDER_ITEMS",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICES_OrderId",
                table: "INVOICES",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_INVOICES_ORDERS_OrderId",
                table: "INVOICES",
                column: "OrderId",
                principalTable: "ORDERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_ITEMS_ITEMS_ItemId",
                table: "ORDER_ITEMS",
                column: "ItemId",
                principalTable: "ITEMS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS",
                column: "OrderId",
                principalTable: "ORDERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_INVOICES_ORDERS_OrderId",
                table: "INVOICES");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_ITEMS_ITEMS_ItemId",
                table: "ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_STATUSES_StatusID",
                table: "ORDERS");

            migrationBuilder.DropIndex(
                name: "IX_ORDERS_StatusID",
                table: "ORDERS");

            migrationBuilder.DropIndex(
                name: "IX_ORDER_ITEMS_ItemId",
                table: "ORDER_ITEMS");

            migrationBuilder.DropIndex(
                name: "IX_INVOICES_OrderId",
                table: "INVOICES");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "ORDER_ITEMS",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                table: "ORDER_ITEMS",
                column: "OrderId",
                principalTable: "ORDERS",
                principalColumn: "Id");
        }
    }
}
