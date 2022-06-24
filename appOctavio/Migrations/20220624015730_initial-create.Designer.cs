﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace appOctavio.Migrations
{
    [DbContext(typeof(CarrosDB))]
    [Migration("20220624015730_initial-create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("libOctavio.Carro", b =>
                {
                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("EstaEncendido")
                        .HasColumnType("bit");

                    b.Property<string>("NoSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Puertas")
                        .HasColumnType("int");

                    b.Property<int>("Ruedas")
                        .HasColumnType("int");

                    b.HasKey("SKU");

                    b.ToTable("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}