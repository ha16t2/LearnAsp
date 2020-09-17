using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bPetClinicSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("95c68dd1-1a36-4b06-bf6e-47de25dc6515"),
                column: "ConcurrencyStamp",
                value: "36171a6e-351f-4141-94b8-52a4711b5539");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e820b10-8555-4fce-9835-149e4f57a9a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbbb7c11-bac0-4fe0-a34f-c8679ccaac41", "AQAAAAEAACcQAAAAEJnhNNRNer5AizV6DcvhJ3bc1cQYZrp3NDVybrflUSZDW2cPZtjzadSLWmx3diaInw==" });

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
                value: new DateTime(2020, 9, 11, 6, 48, 42, 486, DateTimeKind.Local).AddTicks(6846));
        }
    }
}
