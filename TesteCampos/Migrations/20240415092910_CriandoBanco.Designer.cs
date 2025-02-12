﻿// <auto-generated />
using System;
using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TesteCampos.Migrations
{
    [DbContext(typeof(SistemaDbContext))]
    [Migration("20240415092910_CriandoBanco")]
    partial class CriandoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteCampos.Models.ClienteModel", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nmCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCliente");

                    b.ToTable("tbcliente");
                });

            modelBuilder.Entity("TesteCampos.Models.ProdutoModel", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProduto"));

                    b.Property<string>("dscProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("vlrUnitario")
                        .HasColumnType("real");

                    b.HasKey("idProduto");

                    b.ToTable("tbproduto");
                });

            modelBuilder.Entity("TesteCampos.Models.VendaModel", b =>
                {
                    b.Property<int>("idVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVenda"));

                    b.Property<DateTime>("dthVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idProduto")
                        .HasColumnType("int");

                    b.Property<int>("qtdVenda")
                        .HasColumnType("int");

                    b.Property<float>("vlrTotalVenda")
                        .HasColumnType("real");

                    b.Property<float>("vlrUnitarioVenda")
                        .HasColumnType("real");

                    b.HasKey("idVenda");

                    b.ToTable("tbvenda");
                });
#pragma warning restore 612, 618
        }
    }
}
