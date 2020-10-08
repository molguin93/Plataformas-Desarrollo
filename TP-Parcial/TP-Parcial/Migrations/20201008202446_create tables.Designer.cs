﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_Parcial;

namespace TP_Parcial.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201008202446_create tables")]
    partial class createtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("TP_Parcial.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("detId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnName("tiempo")
                        .HasColumnType("int(5)");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("TP_Parcial.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nRecurso")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("TP_Parcial.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("taskId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnName("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Estimacion")
                        .HasColumnName("estimacion")
                        .HasColumnType("int(2)");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnName("vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("TP_Parcial.Usuario", b =>
                {
                    b.Property<int>("UsuarioPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("pass")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nUsuario")
                        .HasColumnType("varchar(50)");

                    b.HasKey("UsuarioPK");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TP_Parcial.Detalle", b =>
                {
                    b.HasOne("TP_Parcial.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_Parcial.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Parcial.Recurso", b =>
                {
                    b.HasOne("TP_Parcial.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Parcial.Tarea", b =>
                {
                    b.HasOne("TP_Parcial.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
