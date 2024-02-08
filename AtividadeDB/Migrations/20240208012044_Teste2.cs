﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtividadeDB.Migrations
{
    /// <inheritdoc />
    public partial class Teste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento2",
                table: "Pessoas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataNascimento2",
                table: "Pessoas",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
