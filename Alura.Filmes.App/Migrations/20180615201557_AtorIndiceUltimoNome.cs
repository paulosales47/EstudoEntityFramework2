using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Filmes.App.Migrations
{
    public partial class AtorIndiceUltimoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_actor_last_name",
                table: "actor",
                column: "last_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_actor_last_name",
                table: "actor");
        }
    }
}
