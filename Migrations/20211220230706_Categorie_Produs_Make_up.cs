using Microsoft.EntityFrameworkCore.Migrations;

namespace Barsovan_Narcisa_Proiect.Migrations
{
    public partial class Categorie_Produs_Make_up : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FurnizorID",
                table: "Produs_Make_up",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Catergorie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Furnizor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Furnizor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnizor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categorie_Produs_Make_up",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produs_Make_upID = table.Column<int>(type: "int", nullable: false),
                    CategorieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie_Produs_Make_up", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorie_Produs_Make_up_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categorie_Produs_Make_up_Produs_Make_up_Produs_Make_upID",
                        column: x => x.Produs_Make_upID,
                        principalTable: "Produs_Make_up",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_Make_up_FurnizorID",
                table: "Produs_Make_up",
                column: "FurnizorID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Produs_Make_up_CategorieID",
                table: "Categorie_Produs_Make_up",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Produs_Make_up_Produs_Make_upID",
                table: "Categorie_Produs_Make_up",
                column: "Produs_Make_upID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_Make_up_Furnizor_FurnizorID",
                table: "Produs_Make_up",
                column: "FurnizorID",
                principalTable: "Furnizor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_Make_up_Furnizor_FurnizorID",
                table: "Produs_Make_up");

            migrationBuilder.DropTable(
                name: "Categorie_Produs_Make_up");

            migrationBuilder.DropTable(
                name: "Furnizor");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Produs_Make_up_FurnizorID",
                table: "Produs_Make_up");

            migrationBuilder.DropColumn(
                name: "FurnizorID",
                table: "Produs_Make_up");
        }
    }
}
