﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.API.Data;

namespace ProEventos.API.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230206193623_UpdateEvento")]
    partial class UpdateEvento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ProEventos.API.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Local")
                        .HasColumnType("longtext");

                    b.Property<string>("Lote")
                        .HasColumnType("longtext");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tema")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
