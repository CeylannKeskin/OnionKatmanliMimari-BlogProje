using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Infrastructure.Migrations
{
    public partial class AddStampData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(4521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(6317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(3385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(5510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(1752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 938, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 639, DateTimeKind.Local).AddTicks(3542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 930, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate" },
                values: new object[] { "98434239-1e38-4ada-b7d3-07a4fc5ae9df", new DateTime(2023, 9, 19, 13, 50, 34, 639, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate" },
                values: new object[] { "d7e16864-f305-4e25-be44-b4eac69686d4", new DateTime(2023, 9, 19, 13, 50, 34, 639, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe9b6ea-d089-421d-842b-0b8ad8367eaf", "AQAAAAEAACcQAAAAEEwEIVGQw7r/tG+GGIeQRx4uyiECi8GiY0W8TzQNYS4+V7zgfFiBOsc4c9b5jHycKQ==", "59ef074b-5bc6-4c0a-b1a9-b91536b792ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(1675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Likes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(3888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 939, DateTimeKind.Local).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 938, DateTimeKind.Local).AddTicks(8411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 650, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 15, 10, 43, 38, 930, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 50, 34, 639, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreateDate" },
                values: new object[] { "789bc403-05db-4f5e-9898-18242869403c", new DateTime(2023, 9, 15, 10, 43, 38, 930, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreateDate" },
                values: new object[] { "b1c453bd-a2e9-405c-b957-55ade7e2f384", new DateTime(2023, 9, 15, 10, 43, 38, 930, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d4c3d33-036b-458b-aa5c-278b9e66d006", "AQAAAAEAACcQAAAAENniM4N0by2vGNd+zEEKaCI4gbMFhrjLuRG8T7Ci7IBqcVOIqZedWl5+S0mGh5sxdA==", null });
        }
    }
}
