using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartTestTaskKozitski.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                column: "Area",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                column: "Area",
                value: 3000);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                column: "Area",
                value: 4000);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                column: "Area",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                column: "Area",
                value: 6000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                column: "Area",
                value: 500);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                column: "Area",
                value: 300);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                column: "Area",
                value: 400);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                column: "Area",
                value: 200);

            migrationBuilder.UpdateData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                column: "Area",
                value: 600);
        }
    }
}
