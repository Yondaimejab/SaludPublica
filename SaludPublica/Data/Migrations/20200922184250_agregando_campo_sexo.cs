using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class agregando_campo_sexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sintomaPorEnfermedades_Enfermedades_EnfermedadID",
                table: "sintomaPorEnfermedades");

            migrationBuilder.DropForeignKey(
                name: "FK_sintomaPorEnfermedades_Sintomas_SintomaID",
                table: "sintomaPorEnfermedades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sintomaPorEnfermedades",
                table: "sintomaPorEnfermedades");

            migrationBuilder.RenameTable(
                name: "sintomaPorEnfermedades",
                newName: "SintomaPorEnfermedades");

            migrationBuilder.RenameIndex(
                name: "IX_sintomaPorEnfermedades_SintomaID",
                table: "SintomaPorEnfermedades",
                newName: "IX_SintomaPorEnfermedades_SintomaID");

            migrationBuilder.RenameIndex(
                name: "IX_sintomaPorEnfermedades_EnfermedadID",
                table: "SintomaPorEnfermedades",
                newName: "IX_SintomaPorEnfermedades_EnfermedadID");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SintomaPorEnfermedades",
                table: "SintomaPorEnfermedades",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SintomaPorEnfermedades_Enfermedades_EnfermedadID",
                table: "SintomaPorEnfermedades",
                column: "EnfermedadID",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SintomaPorEnfermedades_Sintomas_SintomaID",
                table: "SintomaPorEnfermedades",
                column: "SintomaID",
                principalTable: "Sintomas",
                principalColumn: "SintomaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SintomaPorEnfermedades_Enfermedades_EnfermedadID",
                table: "SintomaPorEnfermedades");

            migrationBuilder.DropForeignKey(
                name: "FK_SintomaPorEnfermedades_Sintomas_SintomaID",
                table: "SintomaPorEnfermedades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SintomaPorEnfermedades",
                table: "SintomaPorEnfermedades");

            migrationBuilder.RenameTable(
                name: "SintomaPorEnfermedades",
                newName: "sintomaPorEnfermedades");

            migrationBuilder.RenameIndex(
                name: "IX_SintomaPorEnfermedades_SintomaID",
                table: "sintomaPorEnfermedades",
                newName: "IX_sintomaPorEnfermedades_SintomaID");

            migrationBuilder.RenameIndex(
                name: "IX_SintomaPorEnfermedades_EnfermedadID",
                table: "sintomaPorEnfermedades",
                newName: "IX_sintomaPorEnfermedades_EnfermedadID");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pacientes",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_sintomaPorEnfermedades",
                table: "sintomaPorEnfermedades",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_sintomaPorEnfermedades_Enfermedades_EnfermedadID",
                table: "sintomaPorEnfermedades",
                column: "EnfermedadID",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sintomaPorEnfermedades_Sintomas_SintomaID",
                table: "sintomaPorEnfermedades",
                column: "SintomaID",
                principalTable: "Sintomas",
                principalColumn: "SintomaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
