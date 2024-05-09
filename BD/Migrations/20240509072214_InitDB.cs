using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    codDepto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombreDpto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codDirector = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.codDepto);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    nDIEmp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nomEmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seEmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecIncorporacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salEmp = table.Column<float>(type: "real", nullable: false),
                    comisionE = table.Column<float>(type: "real", nullable: false),
                    cargoE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jefeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codeDepto = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.nDIEmp);
                    table.ForeignKey(
                        name: "FK_Empleado_Departamento_codeDepto",
                        column: x => x.codeDepto,
                        principalTable: "Departamento",
                        principalColumn: "codDepto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_codeDepto",
                table: "Empleado",
                column: "codeDepto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
