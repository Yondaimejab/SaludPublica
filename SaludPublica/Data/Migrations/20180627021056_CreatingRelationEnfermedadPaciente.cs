using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class CreatingRelationEnfermedadPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfermedades_Pacientes_PacienteID",
                table: "Enfermedades");

            migrationBuilder.DropIndex(
                name: "IX_Enfermedades_PacienteID",
                table: "Enfermedades");

            migrationBuilder.DropColumn(
                name: "PacienteID",
                table: "Enfermedades");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Paises",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Paises",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "PacienteID",
                table: "Enfermedades",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enfermedades_PacienteID",
                table: "Enfermedades",
                column: "PacienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfermedades_Pacientes_PacienteID",
                table: "Enfermedades",
                column: "PacienteID",
                principalTable: "Pacientes",
                principalColumn: "PacienteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
