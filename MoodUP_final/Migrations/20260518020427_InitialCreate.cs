using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoodUP_final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emocion",
                columns: table => new
                {
                    IdEmocion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emocion", x => x.IdEmocion);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreUsuario = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Contrasena = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Contenido",
                columns: table => new
                {
                    IdContenido = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEmocion = table.Column<int>(type: "integer", nullable: false),
                    Tipo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Plataforma = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TrailerUrl = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    ImagenUrl = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.IdContenido);
                    table.ForeignKey(
                        name: "FK_Contenido_Emocion_IdEmocion",
                        column: x => x.IdEmocion,
                        principalTable: "Emocion",
                        principalColumn: "IdEmocion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reto",
                columns: table => new
                {
                    IdReto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdEmocion = table.Column<int>(type: "integer", nullable: false),
                    Titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reto", x => x.IdReto);
                    table.ForeignKey(
                        name: "FK_Reto_Emocion_IdEmocion",
                        column: x => x.IdEmocion,
                        principalTable: "Emocion",
                        principalColumn: "IdEmocion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroEmocion",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    IdEmocion = table.Column<int>(type: "integer", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroEmocion", x => x.IdRegistro);
                    table.ForeignKey(
                        name: "FK_RegistroEmocion_Emocion_IdEmocion",
                        column: x => x.IdEmocion,
                        principalTable: "Emocion",
                        principalColumn: "IdEmocion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistroEmocion_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalificacionContenido",
                columns: table => new
                {
                    IdCalificacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    IdContenido = table.Column<int>(type: "integer", nullable: false),
                    Puntuacion = table.Column<int>(type: "integer", nullable: false),
                    FechaCalificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionContenido", x => x.IdCalificacion);
                    table.ForeignKey(
                        name: "FK_CalificacionContenido_Contenido_IdContenido",
                        column: x => x.IdContenido,
                        principalTable: "Contenido",
                        principalColumn: "IdContenido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionContenido_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    IdContenido = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoritos_Contenido_IdContenido",
                        column: x => x.IdContenido,
                        principalTable: "Contenido",
                        principalColumn: "IdContenido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoritos_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RetoCompletado",
                columns: table => new
                {
                    IdRetoCompletado = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    IdReto = table.Column<int>(type: "integer", nullable: false),
                    FechaCompletado = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetoCompletado", x => x.IdRetoCompletado);
                    table.ForeignKey(
                        name: "FK_RetoCompletado_Reto_IdReto",
                        column: x => x.IdReto,
                        principalTable: "Reto",
                        principalColumn: "IdReto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RetoCompletado_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionContenido_IdContenido",
                table: "CalificacionContenido",
                column: "IdContenido");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionContenido_IdUsuario",
                table: "CalificacionContenido",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_IdEmocion",
                table: "Contenido",
                column: "IdEmocion");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_IdContenido",
                table: "Favoritos",
                column: "IdContenido");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_IdUsuario",
                table: "Favoritos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroEmocion_IdEmocion",
                table: "RegistroEmocion",
                column: "IdEmocion");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroEmocion_IdUsuario",
                table: "RegistroEmocion",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Reto_IdEmocion",
                table: "Reto",
                column: "IdEmocion");

            migrationBuilder.CreateIndex(
                name: "IX_RetoCompletado_IdReto",
                table: "RetoCompletado",
                column: "IdReto");

            migrationBuilder.CreateIndex(
                name: "IX_RetoCompletado_IdUsuario",
                table: "RetoCompletado",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalificacionContenido");

            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "RegistroEmocion");

            migrationBuilder.DropTable(
                name: "RetoCompletado");

            migrationBuilder.DropTable(
                name: "Contenido");

            migrationBuilder.DropTable(
                name: "Reto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Emocion");
        }
    }
}
