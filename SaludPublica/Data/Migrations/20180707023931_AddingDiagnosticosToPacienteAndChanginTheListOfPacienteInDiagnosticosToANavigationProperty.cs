using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class AddingDiagnosticosToPacienteAndChanginTheListOfPacienteInDiagnosticosToANavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Diagnosticos_DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DiagnosticoID",
                table: "Pacientes");

            migrationBuilder.AddColumn<int>(
                name: "PacienteID",
                table: "Diagnosticos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_PacienteID",
                table: "Diagnosticos",
                column: "PacienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_Pacientes_PacienteID",
                table: "Diagnosticos",
                column: "PacienteID",
                principalTable: "Pacientes",
                principalColumn: "PacienteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_Pacientes_PacienteID",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_PacienteID",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "PacienteID",
                table: "Diagnosticos");

            migrationBuilder.AddColumn<int>(
                name: "DiagnosticoID",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_DiagnosticoID",
                table: "Pacientes",
                column: "DiagnosticoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Diagnosticos_DiagnosticoID",
                table: "Pacientes",
                column: "DiagnosticoID",
                principalTable: "Diagnosticos",
                principalColumn: "DiagnosticoID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
