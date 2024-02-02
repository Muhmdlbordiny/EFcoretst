using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testscaffold.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "DeliveryOrder",
                startValue: 101L);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryOrder",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "[customerTitle] + ' ' + [customerName]"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 1m),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[price] * [qty]"),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "uniforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uniforms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "uniforms");

            migrationBuilder.DropColumn(
                name: "DeliveryOrder",
                table: "Books");

            migrationBuilder.DropSequence(
                name: "DeliveryOrder");
        }
    }
}
