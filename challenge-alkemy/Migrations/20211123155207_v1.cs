using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace challenge_alkemy.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id_Genero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id_Genero);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id_Personaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Historia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id_Personaje);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSeries",
                columns: table => new
                {
                    Id_PeliculaSerie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_De_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    GeneroId_Genero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSeries", x => x.Id_PeliculaSerie);
                    table.ForeignKey(
                        name: "FK_PeliculaSeries_Generos_GeneroId_Genero",
                        column: x => x.GeneroId_Genero,
                        principalTable: "Generos",
                        principalColumn: "Id_Genero",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSeriePersonaje",
                columns: table => new
                {
                    PeliculaSeriesId_PeliculaSerie = table.Column<int>(type: "int", nullable: false),
                    PersonajesId_Personaje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSeriePersonaje", x => new { x.PeliculaSeriesId_PeliculaSerie, x.PersonajesId_Personaje });
                    table.ForeignKey(
                        name: "FK_PeliculaSeriePersonaje_PeliculaSeries_PeliculaSeriesId_PeliculaSerie",
                        column: x => x.PeliculaSeriesId_PeliculaSerie,
                        principalTable: "PeliculaSeries",
                        principalColumn: "Id_PeliculaSerie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaSeriePersonaje_Personajes_PersonajesId_Personaje",
                        column: x => x.PersonajesId_Personaje,
                        principalTable: "Personajes",
                        principalColumn: "Id_Personaje",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSeriePersonaje_PersonajesId_Personaje",
                table: "PeliculaSeriePersonaje",
                column: "PersonajesId_Personaje");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSeries_GeneroId_Genero",
                table: "PeliculaSeries",
                column: "GeneroId_Genero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculaSeriePersonaje");

            migrationBuilder.DropTable(
                name: "PeliculaSeries");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
