using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class Diagnostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfermedades_Diagnosticos_DiagnosticoID",
                table: "Enfermedades");

            migrationBuilder.DropIndex(
                name: "IX_Enfermedades_DiagnosticoID",
                table: "Enfermedades");

            migrationBuilder.DropColumn(
                name: "DiagnosticoID",
                table: "Enfermedades");

            migrationBuilder.AddColumn<string>(
                name: "DoctorID",
                table: "Diagnosticos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnfermedadID",
                table: "Diagnosticos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnfermedadID1",
                table: "Diagnosticos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_DoctorID",
                table: "Diagnosticos",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_EnfermedadID1",
                table: "Diagnosticos",
                column: "EnfermedadID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_AspNetUsers_DoctorID",
                table: "Diagnosticos",
                column: "DoctorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID1",
                table: "Diagnosticos",
                column: "EnfermedadID1",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_AspNetUsers_DoctorID",
                table: "Diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_DoctorID",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "EnfermedadID",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.AddColumn<int>(
                name: "DiagnosticoID",
                table: "Enfermedades",
                nullable: true);

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
        }
    }
}
