using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenFinalWebAPI.Migrations
{
    public partial class ajoutControllerVilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 57, 11, 746, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 57, 11, 746, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 57, 11, 746, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 57, 11, 746, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 57, 11, 746, DateTimeKind.Local).AddTicks(1392));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 44, 48, 264, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 44, 48, 264, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 44, 48, 264, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 44, 48, 264, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 18, 19, 44, 48, 264, DateTimeKind.Local).AddTicks(1943));
        }
    }
}
