﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apifuncionario.Context;

#nullable disable

namespace apifuncionario.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240322124928_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apifuncionario.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FuncionarioID"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("SetorID")
                        .HasColumnType("integer");

                    b.HasKey("FuncionarioID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("apifuncionario.Models.Setor", b =>
                {
                    b.Property<int>("SetorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SetorID"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("SetorID");

                    b.ToTable("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
