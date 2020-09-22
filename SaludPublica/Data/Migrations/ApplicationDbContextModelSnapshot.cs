﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SaludPublica.Data;
using System;

namespace SaludPublica.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SaludPublica.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SaludPublica.Models.Diagnostico", b =>
                {
                    b.Property<int>("DiagnosticoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment")
                        .HasMaxLength(300);

                    b.Property<DateTime>("Date");

                    b.Property<string>("DoctorID");

                    b.Property<int>("EnfermedadID");

                    b.Property<int>("PacienteID");

                    b.HasKey("DiagnosticoID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("EnfermedadID");

                    b.HasIndex("PacienteID");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("SaludPublica.Models.Enfermedad", b =>
                {
                    b.Property<int>("EnfermedadID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("EnfermedadID");

                    b.ToTable("Enfermedades");
                });

            modelBuilder.Entity("SaludPublica.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Calle");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Email");

                    b.Property<bool>("EsCliente");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("Nombre");

                    b.Property<int>("NumeroDeCasa");

                    b.Property<int>("ProvinciaID");

                    b.Property<string>("Sector");

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("PacienteID");

                    b.HasIndex("ProvinciaID");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("SaludPublica.Models.Pais", b =>
                {
                    b.Property<int>("PaisID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("PaisID");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("SaludPublica.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("PaisID");

                    b.HasKey("ProvinciaID");

                    b.HasIndex("PaisID");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("SaludPublica.Models.Sintoma", b =>
                {
                    b.Property<int>("SintomaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.HasKey("SintomaID");

                    b.ToTable("Sintomas");
                });

            modelBuilder.Entity("SaludPublica.Models.SintomaPorEnfermedades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnfermedadID");

                    b.Property<int>("SintomaID");

                    b.HasKey("ID");

                    b.HasIndex("EnfermedadID");

                    b.HasIndex("SintomaID");

                    b.ToTable("SintomaPorEnfermedades");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SaludPublica.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SaludPublica.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaludPublica.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SaludPublica.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaludPublica.Models.Diagnostico", b =>
                {
                    b.HasOne("SaludPublica.Models.ApplicationUser", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID");

                    b.HasOne("SaludPublica.Models.Enfermedad", "Enfermedad")
                        .WithMany()
                        .HasForeignKey("EnfermedadID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaludPublica.Models.Paciente", "Paciente")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaludPublica.Models.Paciente", b =>
                {
                    b.HasOne("SaludPublica.Models.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaludPublica.Models.Provincia", b =>
                {
                    b.HasOne("SaludPublica.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaludPublica.Models.SintomaPorEnfermedades", b =>
                {
                    b.HasOne("SaludPublica.Models.Enfermedad", "Enfermedad")
                        .WithMany()
                        .HasForeignKey("EnfermedadID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaludPublica.Models.Sintoma", "Sintoma")
                        .WithMany()
                        .HasForeignKey("SintomaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
