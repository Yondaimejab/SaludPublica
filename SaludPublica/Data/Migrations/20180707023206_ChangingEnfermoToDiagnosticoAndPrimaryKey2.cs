using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class ChangingEnfermoToDiagnosticoAndPrimaryKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiagnosticoID",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiagnosticoID",
                table: "Enfermedades",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    DiagnosticoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.DiagnosticoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_DiagnosticoID",
                table: "Pacientes",
                column: "DiagnosticoID");

            migrationBuilder.CreateIndex(
                name: "IX_Enfermedades_DiagnosticoID",
                table: "Enfermedades",
                column: "DiagnosticoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfermedades_Diagnosticos_DiagnosticoID",
                table: "Enfermedades",
                column: "DiagnosticoID",
                principalTable: "Diagnosticos",
                principalColumn: "DiagnosticoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Diagnosticos_DiagnosticoID",
                table: "Pacientes",
                column: "DiagnosticoID",
                principalTable: "Diagnosticos",
                principalColumn: "DiagnosticoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfermedades_Diagnosticos_DiagnosticoID",
                table: "Enfermedades");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Diagnosticos_DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Enfermedades_DiagnosticoID",
                table: "Enfermedades");

            migrationBuilder.DropColumn(
                name: "DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DiagnosticoID",
                table: "Enfermedades");
        }
    }
}
