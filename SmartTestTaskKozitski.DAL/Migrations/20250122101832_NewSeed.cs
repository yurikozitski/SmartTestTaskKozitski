using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartTestTaskKozitski.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"),
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"),
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "Quantity",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"),
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"),
                column: "Quantity",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                column: "Quantity",
                value: 50);
        }
    }
}
