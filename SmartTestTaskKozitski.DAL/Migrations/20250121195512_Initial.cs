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
