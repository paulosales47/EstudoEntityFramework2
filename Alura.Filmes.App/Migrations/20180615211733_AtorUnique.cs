﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Filmes.App.Migrations
{
    public partial class AtorUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_actor_first_name_last_name",
                table: "actor",
                columns: new[] { "first_name", "last_name" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_actor_first_name_last_name",
                table: "actor");
        }
    }
}
