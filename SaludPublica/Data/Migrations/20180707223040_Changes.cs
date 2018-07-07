using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sintomas_Enfermedades_EnfermedadID",
                table: "Sintomas");

            migrationBuilder.DropIndex(
                name: "IX_Sintomas_EnfermedadID",
                table: "Sintomas");

            migrationBuilder.DropColumn(
                name: "EnfermedadID",
                table: "Sintomas");

            migrationBuilder.CreateTable(
                name: "sintomaPorEnfermedades",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnfermedadID = table.Column<int>(nullable: false),
                    SintomaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sintomaPorEnfermedades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_sintomaPorEnfermedades_Enfermedades_EnfermedadID",
                        column: x => x.EnfermedadID,
                        principalTable: "Enfermedades",
                        principalColumn: "EnfermedadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sintomaPorEnfermedades_Sintomas_SintomaID",
                        column: x => x.SintomaID,
                        principalTable: "Sintomas",
                        principalColumn: "SintomaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sintomaPorEnfermedades_EnfermedadID",
                table: "sintomaPorEnfermedades",
                column: "EnfermedadID");

            migrationBuilder.CreateIndex(
                name: "IX_sintomaPorEnfermedades_SintomaID",
                table: "sintomaPorEnfermedades",
                column: "SintomaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sintomaPorEnfermedades");

            migrationBuilder.AddColumn<int>(
                name: "EnfermedadID",
                table: "Sintomas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sintomas_EnfermedadID",
                table: "Sintomas",
                column: "EnfermedadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sintomas_Enfermedades_EnfermedadID",
                table: "Sintomas",
                column: "EnfermedadID",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
