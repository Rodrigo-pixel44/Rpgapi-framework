using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "Passwordhash" },
                values: new object[] { new byte[] { 110, 51, 0, 103, 137, 117, 80, 82, 59, 86, 196, 177, 233, 21, 149, 29, 76, 71, 157, 103, 64, 146, 198, 84, 33, 251, 240, 155, 132, 179, 151, 55, 117, 13, 188, 7, 67, 137, 83, 79, 197, 193, 91, 22, 9, 219, 76, 254, 228, 178, 125, 183, 23, 141, 31, 25, 137, 150, 73, 53, 17, 112, 92, 228, 36, 108, 38, 24, 194, 183, 82, 13, 49, 131, 88, 111, 193, 7, 46, 109, 221, 177, 76, 181, 22, 236, 114, 99, 8, 138, 101, 60, 142, 141, 32, 1, 64, 40, 20, 107, 5, 31, 235, 207, 247, 175, 58, 124, 253, 74, 118, 69, 208, 61, 105, 198, 205, 28, 174, 83, 214, 190, 193, 89, 129, 218, 4, 166 }, new byte[] { 63, 217, 213, 117, 24, 64, 156, 225, 120, 122, 206, 165, 59, 72, 249, 163, 70, 248, 2, 206, 154, 95, 69, 229, 71, 210, 211, 120, 182, 2, 175, 136, 221, 169, 213, 52, 40, 141, 224, 127, 49, 34, 109, 100, 214, 13, 150, 95, 229, 32, 9, 57, 24, 79, 150, 19, 133, 147, 30, 181, 191, 232, 2, 75 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "Passwordhash" },
                values: new object[] { new byte[] { 238, 75, 69, 7, 82, 218, 184, 221, 6, 20, 74, 70, 4, 66, 150, 24, 184, 190, 153, 232, 23, 38, 102, 217, 243, 241, 188, 76, 148, 28, 244, 39, 241, 155, 144, 112, 243, 35, 214, 214, 149, 143, 203, 164, 7, 153, 34, 111, 20, 188, 77, 218, 126, 166, 177, 75, 234, 143, 126, 89, 231, 241, 83, 240, 101, 199, 67, 17, 215, 124, 154, 33, 229, 107, 11, 7, 15, 43, 165, 142, 28, 117, 13, 91, 13, 105, 128, 27, 246, 80, 156, 247, 55, 157, 0, 30, 229, 126, 2, 108, 253, 158, 112, 181, 251, 41, 95, 42, 219, 215, 237, 27, 184, 143, 72, 117, 47, 128, 119, 153, 188, 35, 19, 218, 220, 224, 156, 135 }, new byte[] { 163, 61, 75, 226, 22, 107, 18, 79, 90, 246, 151, 89, 13, 152, 207, 208, 9, 14, 136, 8, 170, 49, 35, 164, 179, 98, 70, 92, 167, 254, 203, 197, 39, 116, 1, 180, 127, 227, 99, 84, 189, 238, 19, 132, 162, 165, 170, 24, 24, 145, 112, 83, 77, 73, 90, 119, 146, 231, 236, 222, 112, 65, 174, 51 } });
        }
    }
}
