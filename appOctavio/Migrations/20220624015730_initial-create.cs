using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appOctavio.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ruedas = table.Column<int>(type: "int", nullable: false),
                    Puertas = table.Column<int>(type: "int", nullable: false),
                    NoSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEncendido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.SKU);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carros");
        }
    }
}
