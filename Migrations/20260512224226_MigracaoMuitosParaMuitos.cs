using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "Passwordhash" },
                values: new object[] { new byte[] { 211, 72, 217, 144, 168, 125, 4, 79, 132, 214, 121, 124, 82, 103, 25, 229, 129, 108, 93, 119, 16, 192, 20, 51, 253, 171, 98, 2, 240, 241, 26, 225, 207, 142, 4, 18, 114, 169, 154, 18, 40, 228, 7, 175, 215, 136, 193, 101, 84, 184, 209, 87, 6, 184, 194, 226, 130, 70, 53, 16, 37, 150, 118, 191, 142, 2, 117, 132, 80, 52, 90, 151, 146, 117, 216, 189, 138, 48, 25, 231, 190, 138, 98, 83, 139, 194, 126, 144, 11, 182, 149, 136, 9, 27, 172, 175, 214, 156, 251, 61, 136, 223, 41, 253, 34, 59, 197, 106, 212, 50, 81, 75, 55, 171, 78, 3, 196, 149, 8, 39, 158, 43, 138, 151, 143, 133, 185, 31 }, new byte[] { 136, 153, 118, 200, 9, 244, 229, 62, 88, 108, 132, 169, 134, 182, 130, 22, 252, 111, 185, 101, 88, 85, 0, 182, 51, 63, 20, 117, 185, 72, 120, 34, 211, 107, 159, 254, 86, 34, 120, 184, 223, 147, 47, 213, 218, 161, 105, 135, 92, 21, 209, 190, 139, 233, 255, 169, 230, 35, 121, 45, 90, 226, 114, 92 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "Passwordhash" },
                values: new object[] { new byte[] { 110, 51, 0, 103, 137, 117, 80, 82, 59, 86, 196, 177, 233, 21, 149, 29, 76, 71, 157, 103, 64, 146, 198, 84, 33, 251, 240, 155, 132, 179, 151, 55, 117, 13, 188, 7, 67, 137, 83, 79, 197, 193, 91, 22, 9, 219, 76, 254, 228, 178, 125, 183, 23, 141, 31, 25, 137, 150, 73, 53, 17, 112, 92, 228, 36, 108, 38, 24, 194, 183, 82, 13, 49, 131, 88, 111, 193, 7, 46, 109, 221, 177, 76, 181, 22, 236, 114, 99, 8, 138, 101, 60, 142, 141, 32, 1, 64, 40, 20, 107, 5, 31, 235, 207, 247, 175, 58, 124, 253, 74, 118, 69, 208, 61, 105, 198, 205, 28, 174, 83, 214, 190, 193, 89, 129, 218, 4, 166 }, new byte[] { 63, 217, 213, 117, 24, 64, 156, 225, 120, 122, 206, 165, 59, 72, 249, 163, 70, 248, 2, 206, 154, 95, 69, 229, 71, 210, 211, 120, 182, 2, 175, 136, 221, 169, 213, 52, 40, 141, 224, 127, 49, 34, 109, 100, 214, 13, 150, 95, 229, 32, 9, 57, 24, 79, 150, 19, 133, 147, 30, 181, 191, 232, 2, 75 } });
        }
    }
}
