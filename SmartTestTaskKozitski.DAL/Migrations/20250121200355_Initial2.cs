using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartTestTaskKozitski.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("01d77963-da2d-4dd4-81a2-fd64e0e8fd8e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4b57e514-373a-4eca-8a62-fc0c2859e3ea"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6b7f2ff8-7b20-497b-90ce-f04def9d1011"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("990b2440-4ba8-47e4-9876-7863a1ec53a2"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("cc2fa426-ac7f-476a-86df-8d1d916a744c"));

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ProcessEquipmentTypeId", "ProductionFacilityId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"), new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"), 10 },
                    { new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"), new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"), new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"), 20 },
                    { new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"), new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"), new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"), 30 },
                    { new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"), new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"), new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"), 40 },
                    { new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"), new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"), new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"), 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"));

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ProcessEquipmentTypeId", "ProductionFacilityId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("01d77963-da2d-4dd4-81a2-fd64e0e8fd8e"), new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"), new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"), 30 },
                    { new Guid("4b57e514-373a-4eca-8a62-fc0c2859e3ea"), new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"), new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"), 40 },
                    { new Guid("6b7f2ff8-7b20-497b-90ce-f04def9d1011"), new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"), new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"), 20 },
                    { new Guid("990b2440-4ba8-47e4-9876-7863a1ec53a2"), new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"), new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"), 50 },
                    { new Guid("cc2fa426-ac7f-476a-86df-8d1d916a744c"), new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"), new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"), 10 }
                });
        }
    }
}
