﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChainOfResponsability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ColumnAmountRemovedFromOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ORDERS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "ORDERS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
