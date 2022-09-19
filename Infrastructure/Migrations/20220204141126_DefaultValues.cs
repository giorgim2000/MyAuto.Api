using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class DefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AdCreationTime",
                table: "CarAds",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2022, 2, 4, 18, 11, 26, 674, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2022, 2, 4, 18, 7, 1, 710, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 4, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AdCreationTime",
                table: "CarAds",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2022, 2, 4, 18, 7, 1, 710, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2022, 2, 4, 18, 11, 26, 674, DateTimeKind.Unspecified).AddTicks(2352), new TimeSpan(0, 4, 0, 0, 0)));
        }
    }
}
