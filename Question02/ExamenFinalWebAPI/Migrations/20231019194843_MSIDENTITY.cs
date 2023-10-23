using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenFinalWebAPI.Migrations
{
    public partial class MSIDENTITY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 48, 43, 285, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 48, 43, 285, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 48, 43, 285, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 48, 43, 285, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 48, 43, 285, DateTimeKind.Local).AddTicks(1672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 7, 1, 913, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 7, 1, 913, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 7, 1, 913, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 7, 1, 913, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 7, 1, 913, DateTimeKind.Local).AddTicks(3958));
        }
    }
}
