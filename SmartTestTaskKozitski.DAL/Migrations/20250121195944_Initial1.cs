using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartTestTaskKozitski.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("0facaf87-f3f6-4d1d-82e2-3ae098ef3732"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2a2b89c3-701f-4f0e-8343-5d83d7111eee"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("698be234-5be8-4e2e-b4b0-8915725464f7"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("e8b16822-ca86-4deb-9043-2ac1d6c15a9e"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("eaa38ecd-06b9-40b3-8323-fcb5edc748dd"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("3108ebb3-5899-4e67-a2b2-3c0177d0398f"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f0bcd32-8183-489c-8a17-295b7d713945"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("9e959bfc-4128-4218-92c9-6d05daecd4c9"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("befd5d2d-b939-459a-9634-2585900c4075"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("f767a81f-65ee-445c-88c2-11cb42946c3f"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("07d53b3a-e098-45bb-bfcb-fa34c2473395"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("684ec398-9db8-4554-a8e0-8232d62ff668"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("89af33b9-6059-4fad-b3fa-5a75f03da498"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("b6bdda1a-e99c-4f53-8505-cde90e9f7b61"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("c70d64e0-8b05-437e-b927-53a2b5a30047"));

            migrationBuilder.InsertData(
                table: "ProcessEquipmentTypes",
                columns: new[] { "Id", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"), 75, 1002L, "TypeB" },
                    { new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"), 150, 1005L, "TypeE" },
                    { new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"), 100, 1003L, "TypeC" },
                    { new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"), 50, 1001L, "TypeA" },
                    { new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"), 125, 1004L, "TypeD" }
                });

            migrationBuilder.InsertData(
                table: "ProductionFacilities",
                columns: new[] { "Id", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"), 500, 2004L, "FacilityD" },
                    { new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"), 300, 2002L, "FacilityB" },
                    { new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"), 400, 2003L, "FacilityC" },
                    { new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"), 200, 2001L, "FacilityA" },
                    { new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"), 600, 2005L, "FacilityE" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"));

            migrationBuilder.DeleteData(
                table: "ProcessEquipmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"));

            migrationBuilder.DeleteData(
                table: "ProductionFacilities",
                keyColumn: "Id",
                keyValue: new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"));

            migrationBuilder.InsertData(
                table: "ProcessEquipmentTypes",
                columns: new[] { "Id", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("3108ebb3-5899-4e67-a2b2-3c0177d0398f"), 75, 1002L, "TypeB" },
                    { new Guid("8f0bcd32-8183-489c-8a17-295b7d713945"), 100, 1003L, "TypeC" },
                    { new Guid("9e959bfc-4128-4218-92c9-6d05daecd4c9"), 125, 1004L, "TypeD" },
                    { new Guid("befd5d2d-b939-459a-9634-2585900c4075"), 50, 1001L, "TypeA" },
                    { new Guid("f767a81f-65ee-445c-88c2-11cb42946c3f"), 150, 1005L, "TypeE" }
                });

            migrationBuilder.InsertData(
                table: "ProductionFacilities",
                columns: new[] { "Id", "Area", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("07d53b3a-e098-45bb-bfcb-fa34c2473395"), 400, 2003L, "FacilityC" },
                    { new Guid("684ec398-9db8-4554-a8e0-8232d62ff668"), 500, 2004L, "FacilityD" },
                    { new Guid("89af33b9-6059-4fad-b3fa-5a75f03da498"), 300, 2002L, "FacilityB" },
                    { new Guid("b6bdda1a-e99c-4f53-8505-cde90e9f7b61"), 200, 2001L, "FacilityA" },
                    { new Guid("c70d64e0-8b05-437e-b927-53a2b5a30047"), 600, 2005L, "FacilityE" }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ProcessEquipmentTypeId", "ProductionFacilityId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0facaf87-f3f6-4d1d-82e2-3ae098ef3732"), new Guid("3108ebb3-5899-4e67-a2b2-3c0177d0398f"), new Guid("89af33b9-6059-4fad-b3fa-5a75f03da498"), 20 },
                    { new Guid("2a2b89c3-701f-4f0e-8343-5d83d7111eee"), new Guid("f767a81f-65ee-445c-88c2-11cb42946c3f"), new Guid("c70d64e0-8b05-437e-b927-53a2b5a30047"), 50 },
                    { new Guid("698be234-5be8-4e2e-b4b0-8915725464f7"), new Guid("befd5d2d-b939-459a-9634-2585900c4075"), new Guid("b6bdda1a-e99c-4f53-8505-cde90e9f7b61"), 10 },
                    { new Guid("e8b16822-ca86-4deb-9043-2ac1d6c15a9e"), new Guid("9e959bfc-4128-4218-92c9-6d05daecd4c9"), new Guid("684ec398-9db8-4554-a8e0-8232d62ff668"), 40 },
                    { new Guid("eaa38ecd-06b9-40b3-8323-fcb5edc748dd"), new Guid("8f0bcd32-8183-489c-8a17-295b7d713945"), new Guid("07d53b3a-e098-45bb-bfcb-fa34c2473395"), 30 }
                });
        }
    }
}
