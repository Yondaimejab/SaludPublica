using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SaludPublica.Data.Migrations
{
    public partial class FixingEnfermedadID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "EnfermedadID1",
                table: "Diagnosticos");

            migrationBuilder.AlterColumn<int>(
                name: "EnfermedadID",
                table: "Diagnosticos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_EnfermedadID",
                table: "Diagnosticos",
                column: "EnfermedadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID",
                table: "Diagnosticos",
                column: "EnfermedadID",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_EnfermedadID",
                table: "Diagnosticos");

            migrationBuilder.AlterColumn<string>(
                name: "EnfermedadID",
                table: "Diagnosticos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EnfermedadID1",
                table: "Diagnosticos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_EnfermedadID1",
                table: "Diagnosticos",
                column: "EnfermedadID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_Enfermedades_EnfermedadID1",
                table: "Diagnosticos",
                column: "EnfermedadID1",
                principalTable: "Enfermedades",
                principalColumn: "EnfermedadID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
