using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ConstantDataCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "CarTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Coupe" },
                    { 3, "SUV" },
                    { 4, "Minivan" },
                    { 5, "Cabriolet" },
                    { 6, "Small Car" },
                    { 7, "Limousine" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "FuelTypeId", "FuelName" },
                values: new object[,]
                {
                    { 1, "Petrol" },
                    { 2, "Diesel" },
                    { 3, "Hybrid" },
                    { 4, "Electric" },
                    { 5, "Gas" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "LocationName" },
                values: new object[,]
                {
                    { 1, "Tbilisi" },
                    { 2, "Batumi" },
                    { 3, "Kutaisi" },
                    { 4, "Rustavi" },
                    { 5, "Telavi" },
                    { 6, "Zestafoni" },
                    { 7, "Gori" },
                    { 8, "Khashuri" },
                    { 9, "Poti" },
                    { 10, "Qobuleti" }
                });

            migrationBuilder.InsertData(
                table: "TransmissionTypes",
                columns: new[] { "TransmissionTypeId", "TransmissionName" },
                values: new object[,]
                {
                    { 1, "Manual" },
                    { 2, "Automatic" },
                    { 3, "Semi-Automatic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarTypes",
                keyColumn: "CarTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "FuelTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "FuelTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "FuelTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "FuelTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "FuelTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TransmissionTypes",
                keyColumn: "TransmissionTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransmissionTypes",
                keyColumn: "TransmissionTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransmissionTypes",
                keyColumn: "TransmissionTypeId",
                keyValue: 3);
        }
    }
}
