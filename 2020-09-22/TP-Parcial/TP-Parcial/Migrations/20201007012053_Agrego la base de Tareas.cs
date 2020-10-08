using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_Parcial.Migrations
{
    public partial class AgregolabasedeTareas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<int>(nullable: false),
                    responsableId = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_responsableId",
                        column: x => x.responsableId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioId",
                table: "Recurso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_responsableId",
                table: "Tarea",
                column: "responsableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");
        }
    }
}
