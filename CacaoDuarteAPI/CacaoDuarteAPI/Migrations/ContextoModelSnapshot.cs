﻿// <auto-generated />
using System;
using CacaoDuarteAPI.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CacaoDuarteAPI.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CacaoDuarteAPI.Models.EmpresaCompraCacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PaginaWeb")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EmpresaCompraCacaos");
                });

            modelBuilder.Entity("CacaoDuarteAPI.Models.PrecioCacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdEmpresaCompraCacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTipoCacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecioPorQuintal")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresaCompraCacao");

                    b.HasIndex("IdTipoCacao");

                    b.ToTable("PreciosCacaos");
                });

            modelBuilder.Entity("CacaoDuarteAPI.Models.TiposCacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TiposCacaos");
                });

            modelBuilder.Entity("CacaoDuarteAPI.Models.PrecioCacao", b =>
                {
                    b.HasOne("CacaoDuarteAPI.Models.EmpresaCompraCacao", "EmpresaCompraCacao")
                        .WithMany()
                        .HasForeignKey("IdEmpresaCompraCacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CacaoDuarteAPI.Models.TiposCacao", "TiposCacao")
                        .WithMany("PrecioCacao")
                        .HasForeignKey("IdTipoCacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaCompraCacao");

                    b.Navigation("TiposCacao");
                });

            modelBuilder.Entity("CacaoDuarteAPI.Models.TiposCacao", b =>
                {
                    b.Navigation("PrecioCacao");
                });
#pragma warning restore 612, 618
        }
    }
}
