using Microsoft.EntityFrameworkCore.Migrations;
using System;
namespace Barsovan_Narcisa_Proiect.Migrations
{
    public partial class Data_lansarii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
               name: "Pret",
               table: "Produs_Make_up",
               type: "decimal(6,2)",
               nullable: false,
               oldClrType: typeof(decimal),
               oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_lansarii",
                table: "Produs_Make_up",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "Data_lansarii",
               table: "Produs_Make_up");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Produs_Make_up",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
