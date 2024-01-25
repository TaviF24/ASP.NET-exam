﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(WebAppContext))]
    [Migration("20240125130008_ThirdCreate")]
    partial class ThirdCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApp.Models.Materii", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("WebApp.Models.ModelRelation", b =>
                {
                    b.Property<Guid>("MateriiId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProfesoriId")
                        .HasColumnType("char(36)");

                    b.HasKey("MateriiId", "ProfesoriId");

                    b.HasIndex("ProfesoriId");

                    b.ToTable("ModelRelations");
                });

            modelBuilder.Entity("WebApp.Models.Profesori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Salariu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("WebApp.Models.ModelRelation", b =>
                {
                    b.HasOne("WebApp.Models.Materii", "Materii")
                        .WithMany("ModelsRelations")
                        .HasForeignKey("MateriiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Profesori", "Profesori")
                        .WithMany("ModelsRelations")
                        .HasForeignKey("ProfesoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materii");

                    b.Navigation("Profesori");
                });

            modelBuilder.Entity("WebApp.Models.Materii", b =>
                {
                    b.Navigation("ModelsRelations");
                });

            modelBuilder.Entity("WebApp.Models.Profesori", b =>
                {
                    b.Navigation("ModelsRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
