using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categorias(CategoriaNome, CategoriaDescricao)" +
                "VALUES ('Normal', 'Lanches feitos com igredientes normais')");
            migrationBuilder.Sql("INSERT INTO categorias(CategoriaNome, CategoriaDescricao)" +
                "VALUES ('Natural', 'Lanches feitos com igredientes naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categorias");
        }
    }
}
