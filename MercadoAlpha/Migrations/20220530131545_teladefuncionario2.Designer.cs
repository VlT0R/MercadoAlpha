﻿// <auto-generated />
using System;
using MercadoAlpha;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MercadoAlpha.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220530131545_teladefuncionario2")]
    partial class teladefuncionario2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MercadoAlpha.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<string>("datanascimento")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("endereco")
                        .HasColumnType("text");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nomesocial")
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .HasColumnType("text");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CLIENTES");
                });

            modelBuilder.Entity("MercadoAlpha.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cargo")
                        .HasColumnType("text");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("datanasc")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<char>("endereco")
                        .HasColumnType("int");

                    b.Property<string>("nomesocial")
                        .HasColumnType("text");

                    b.Property<int>("rg")
                        .HasColumnType("int");

                    b.Property<string>("sexo")
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FUNCIONARIOS");
                });

            modelBuilder.Entity("MercadoAlpha.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int");

                    b.Property<string>("UnidadeMedida")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PRODUTOS");
                });

            modelBuilder.Entity("MercadoAlpha.Models.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("USUARIOS");
                });
#pragma warning restore 612, 618
        }
    }
}
