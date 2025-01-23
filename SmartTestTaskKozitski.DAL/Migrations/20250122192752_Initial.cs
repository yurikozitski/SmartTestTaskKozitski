using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartTestTaskKozitski.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessEquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessEquipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionFacilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionFacilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductionFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessEquipmentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_ProcessEquipmentTypes_ProcessEquipmentTypeId",
                        column: x => x.ProcessEquipmentTypeId,
                        principalTable: "ProcessEquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_ProductionFacilities_ProductionFacilityId",
                        column: x => x.ProductionFacilityId,
                        principalTable: "ProductionFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    { new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"), 5000, 2004L, "FacilityD" },
                    { new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"), 3000, 2002L, "FacilityB" },
                    { new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"), 4000, 2003L, "FacilityC" },
                    { new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"), 2000, 2001L, "FacilityA" },
                    { new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"), 6000, 2005L, "FacilityE" }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ProcessEquipmentTypeId", "ProductionFacilityId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"), new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"), 2 },
                    { new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"), new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"), new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"), 2 },
                    { new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"), new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"), new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"), 3 },
                    { new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"), new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"), new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"), 1 },
                    { new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"), new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"), new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProcessEquipmentTypeId",
                table: "Contracts",
                column: "ProcessEquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProductionFacilityId",
                table: "Contracts",
                column: "ProductionFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessEquipmentTypes_Code",
                table: "ProcessEquipmentTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionFacilities_Code",
                table: "ProductionFacilities",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "ProcessEquipmentTypes");

            migrationBuilder.DropTable(
                name: "ProductionFacilities");
        }
    }
}
