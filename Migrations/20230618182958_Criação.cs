using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class Criação : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Disputas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Disputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Tx_Narracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Disputas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 209, 214, 174, 62, 234, 39, 145, 222, 39, 119, 90, 175, 200, 155, 104, 249, 10, 224, 34, 19, 33, 64, 190, 72, 131, 184, 97, 116, 163, 83, 192, 250, 21, 202, 98, 132, 217, 120, 182, 211, 150, 164, 253, 172, 156, 39, 239, 87, 216, 104, 31, 172, 67, 221, 130, 175, 169, 63, 70, 28, 234, 175, 81, 141 }, new byte[] { 129, 78, 231, 74, 131, 246, 85, 144, 227, 118, 105, 27, 49, 247, 111, 145, 186, 91, 143, 56, 226, 126, 155, 153, 27, 109, 57, 95, 251, 104, 140, 178, 177, 21, 232, 253, 51, 109, 109, 26, 35, 244, 235, 113, 180, 22, 140, 213, 110, 53, 216, 36, 225, 22, 202, 71, 212, 235, 13, 166, 252, 60, 206, 12, 221, 156, 28, 227, 180, 59, 198, 149, 138, 237, 239, 14, 33, 143, 89, 159, 63, 240, 118, 164, 216, 82, 189, 11, 235, 250, 102, 236, 60, 74, 255, 88, 148, 194, 175, 172, 95, 199, 230, 203, 101, 109, 123, 54, 127, 229, 255, 105, 25, 190, 144, 216, 89, 49, 116, 225, 15, 80, 240, 107, 140, 27, 55, 7 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Disputas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 130, 218, 11, 41, 230, 150, 248, 30, 212, 236, 234, 147, 196, 222, 236, 129, 37, 78, 3, 103, 80, 216, 189, 168, 185, 169, 254, 5, 228, 247, 9, 189, 201, 90, 29, 241, 211, 82, 118, 44, 38, 92, 133, 187, 130, 133, 165, 176, 193, 1, 106, 74, 73, 101, 247, 122, 106, 238, 52, 184, 102, 26, 252 }, new byte[] { 194, 130, 28, 162, 31, 102, 220, 92, 159, 191, 69, 152, 196, 46, 26, 208, 174, 231, 252, 38, 66, 72, 144, 4, 37, 114, 32, 205, 156, 204, 101, 87, 236, 81, 152, 30, 153, 249, 144, 50, 83, 230, 131, 116, 88, 151, 112, 36, 66, 167, 131, 12, 240, 88, 125, 173, 117, 118, 111, 4, 52, 173, 139, 235, 75, 13, 195, 107, 66, 148, 14, 253, 18, 48, 81, 68, 154, 2, 157, 61, 155, 65, 73, 4, 6, 254, 162, 245, 14, 28, 138, 29, 106, 141, 205, 74, 138, 66, 245, 162, 5, 112, 120, 253, 219, 45, 235, 238, 48, 38, 128, 110, 76, 141, 149, 212, 8, 228, 208, 207, 208, 227, 65, 134, 213, 129, 204, 31 } });
        }
    }
}
