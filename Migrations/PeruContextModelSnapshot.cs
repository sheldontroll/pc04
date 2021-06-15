﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pc04.Models;

namespace pc04.Migrations
{
    [DbContext(typeof(PeruContext))]
    partial class PeruContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("pc04.Models.Comentario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("comentario")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("comentarios");
                });

            modelBuilder.Entity("pc04.Models.Fail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("gif")
                        .HasColumnType("text");

                    b.Property<string>("titulo")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("fails");
                });
#pragma warning restore 612, 618
        }
    }
}