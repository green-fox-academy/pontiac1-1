using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ExamPractice.Migrations
{
    public partial class fet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaceships_Planets_PlanetId",
                table: "Spaceships");

            migrationBuilder.DropIndex(
                name: "IX_Spaceships_PlanetId",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "PlanetId",
                table: "Spaceships");

            migrationBuilder.AddColumn<int>(
                name: "DockId",
                table: "Planets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Planets_DockId",
                table: "Planets",
                column: "DockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Spaceships_DockId",
                table: "Planets",
                column: "DockId",
                principalTable: "Spaceships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Spaceships_DockId",
                table: "Planets");

            migrationBuilder.DropIndex(
                name: "IX_Planets_DockId",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "DockId",
                table: "Planets");

            migrationBuilder.AddColumn<int>(
                name: "PlanetId",
                table: "Spaceships",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spaceships_PlanetId",
                table: "Spaceships",
                column: "PlanetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaceships_Planets_PlanetId",
                table: "Spaceships",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
