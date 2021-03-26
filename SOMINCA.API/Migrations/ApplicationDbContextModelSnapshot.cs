﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOMINCA.Domain.Models;

namespace SOMINCA.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("SOMINCA.Domain.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Entrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reservacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("SOMINCA.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehiculosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehiculosId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SOMINCA.Domain.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("SOMINCA.Domain.Models.Reserva", b =>
                {
                    b.HasOne("SOMINCA.Domain.Models.Usuario", "Usuario")
                        .WithMany("Reservas")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SOMINCA.Domain.Models.Usuario", b =>
                {
                    b.HasOne("SOMINCA.Domain.Models.Vehiculo", "Vehiculos")
                        .WithMany()
                        .HasForeignKey("VehiculosId");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("SOMINCA.Domain.Models.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
