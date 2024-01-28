using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3320), "https://www.dotnetmastery.com/bluevillaimages/villa1.jpg", new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3330), "https://www.dotnetmastery.com/bluevillaimages/villa2.jpg", new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3330), "https://www.dotnetmastery.com/bluevillaimages/villa3.jpg", new DateTime(2024, 1, 28, 15, 28, 19, 786, DateTimeKind.Utc).AddTicks(3330) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000), "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg", new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000), "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg", new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3010), "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg", new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3010) });
        }
    }
}
