using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaTableUTCModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 11, 25, 22, 51, 19, 326, DateTimeKind.Utc).AddTicks(6930) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710), new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710), new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710), new DateTime(2023, 11, 25, 22, 23, 54, 87, DateTimeKind.Utc).AddTicks(7710) });
        }
    }
}
