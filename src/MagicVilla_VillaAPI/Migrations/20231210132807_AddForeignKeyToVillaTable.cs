using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3510), new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3520), new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3520), new DateTime(2023, 12, 10, 13, 28, 6, 888, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 12, 6, 23, 2, 32, 673, DateTimeKind.Utc).AddTicks(5130) });
        }
    }
}
