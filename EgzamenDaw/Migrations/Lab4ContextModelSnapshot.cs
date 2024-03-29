﻿// <auto-generated />
using System;
using EgzamenDaw.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EgzamenDaw.Migrations
{
    [DbContext(typeof(Lab4Context))]
    partial class Lab4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EgzamenDaw.Models.Materii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NumeMaterie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("EgzamenDaw.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TipProfesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("EgzamenDaw.Models.ProfesorMaterie", b =>
                {
                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("MaterieId")
                        .HasColumnType("int");

                    b.HasKey("ProfesorId", "MaterieId");

                    b.HasIndex("MaterieId");

                    b.ToTable("ProfessorMaterie");
                });

            modelBuilder.Entity("EgzamenDaw.Models.ProfesorMaterie", b =>
                {
                    b.HasOne("EgzamenDaw.Models.Materii", "Materii")
                        .WithMany("ProfesorMaterie")
                        .HasForeignKey("MaterieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgzamenDaw.Models.Profesor", "Profesor")
                        .WithMany("ProfesorMaterie")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materii");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("EgzamenDaw.Models.Materii", b =>
                {
                    b.Navigation("ProfesorMaterie");
                });

            modelBuilder.Entity("EgzamenDaw.Models.Profesor", b =>
                {
                    b.Navigation("ProfesorMaterie");
                });
#pragma warning restore 612, 618
        }
    }
}
