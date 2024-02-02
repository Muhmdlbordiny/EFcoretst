using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testscaffold.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DeliveryOrder",
                table: "uniforms",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For DeliveryOrder",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryOrder",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValueSql: "Next Value For DeliveryOrder",
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DeliveryOrder",
                table: "uniforms",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "Next Value For DeliveryOrder");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryOrder",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "Next Value For DeliveryOrder");
        }
    }
}
