using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace MercadoAlpha.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    datanascimento = table.Column<string>(type: "text", nullable: true),
                    idade = table.Column<int>(type: "int", nullable: false),
                    sexo = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    endereco = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<int>(type: "int", nullable: false),
                    cargo = table.Column<int>(type: "int", nullable: false),
                    datanasc = table.Column<int>(type: "int", nullable: false),
                    sexo = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    UnidadeDeMedida = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime", nullable: false),
                    QtdEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "PRODUTOS");
        }
    }
}
