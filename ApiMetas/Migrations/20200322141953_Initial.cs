using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMetas.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusMetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CDStatusMeta = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusMetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CDSTipoMeta = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Profissao = table.Column<string>(nullable: true),
                    Empregado = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    Observacao = table.Column<string>(maxLength: 300, nullable: false),
                    TipoMetaId = table.Column<Guid>(nullable: true),
                    StatusMetaId = table.Column<Guid>(nullable: true),
                    UsuarioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metas_StatusMetas_StatusMetaId",
                        column: x => x.StatusMetaId,
                        principalTable: "StatusMetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Metas_TipoMetas_TipoMetaId",
                        column: x => x.TipoMetaId,
                        principalTable: "TipoMetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Metas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Metas_StatusMetaId",
                table: "Metas",
                column: "StatusMetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas_TipoMetaId",
                table: "Metas",
                column: "TipoMetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas_UsuarioId",
                table: "Metas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Metas");

            migrationBuilder.DropTable(
                name: "StatusMetas");

            migrationBuilder.DropTable(
                name: "TipoMetas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
