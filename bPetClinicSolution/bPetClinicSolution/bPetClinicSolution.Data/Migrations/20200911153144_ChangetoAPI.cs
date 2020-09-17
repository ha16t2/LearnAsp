using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bPetClinicSolution.Data.Migrations
{
    public partial class ChangetoAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("95c68dd1-1a36-4b06-bf6e-47de25dc6515"),
                column: "ConcurrencyStamp",
                value: "1f9e3924-d792-4fc7-adb1-3c89462d9721");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e820b10-8555-4fce-9835-149e4f57a9a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db79c677-c301-46dd-9a38-39e4f1552882", "AQAAAAEAACcQAAAAEOAtRZGvUzDXoECPZTTH/C+EkEHWFLHtsntnmsL///tt+c0Q160RhDxwXe2Rcaep2Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 11, 22, 31, 41, 290, DateTimeKind.Local).AddTicks(722));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("95c68dd1-1a36-4b06-bf6e-47de25dc6515"),
                column: "ConcurrencyStamp",
                value: "fe9506ab-af2f-490b-b19b-a39c3c99eebd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e820b10-8555-4fce-9835-149e4f57a9a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "672ce2fd-8219-4e42-a03c-26cf46d63416", "AQAAAAEAACcQAAAAEPYcnoa3p5mTD/yl2FkZuLrL88lpRBsGCsA61/0wR4s9YlpwXgHdyD2PBGReyHvG4w==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 11, 14, 19, 3, 221, DateTimeKind.Local).AddTicks(1387));
        }
    }
}
