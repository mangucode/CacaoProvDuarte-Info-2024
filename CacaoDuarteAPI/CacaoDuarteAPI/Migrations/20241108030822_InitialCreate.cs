using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CacaoDuarteAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaCompraCacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Ubicacion = table.Column<string>(type: "TEXT", nullable: true),
                    PaginaWeb = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaCompraCacaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCacaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreciosCacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdTipoCacao = table.Column<int>(type: "INTEGER", nullable: false),
                    IdEmpresaCompraCacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrecioPorQuintal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciosCacaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreciosCacaos_EmpresaCompraCacaos_IdEmpresaCompraCacao",
                        column: x => x.IdEmpresaCompraCacao,
                        principalTable: "EmpresaCompraCacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreciosCacaos_TiposCacaos_IdTipoCacao",
                        column: x => x.IdTipoCacao,
                        principalTable: "TiposCacaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreciosCacaos_IdEmpresaCompraCacao",
                table: "PreciosCacaos",
                column: "IdEmpresaCompraCacao");

            migrationBuilder.CreateIndex(
                name: "IX_PreciosCacaos_IdTipoCacao",
                table: "PreciosCacaos",
                column: "IdTipoCacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreciosCacaos");

            migrationBuilder.DropTable(
                name: "EmpresaCompraCacaos");

            migrationBuilder.DropTable(
                name: "TiposCacaos");
        }
    }
}
