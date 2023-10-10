﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PadariaDoceAroma.DataBase;

#nullable disable

namespace PadariaDoceAroma.Migrations
{
    [DbContext(typeof(PadariaContext))]
    [Migration("20231010193713_AzureSqlServer_2")]
    partial class AzureSqlServer_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PadariaDoceAroma.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cd_item");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Categoria")
                        .HasColumnType("int")
                        .HasColumnName("ds_categoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ds_descrica");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nm_nome_item");

                    b.HasKey("Id");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("PadariaDoceAroma.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cd_pedido");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_pedido");

                    b.Property<int>("FkItemId")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nm_cliente");

                    b.Property<decimal>("valorPedido")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("vl_produto");

                    b.HasKey("IdPedido");

                    b.HasIndex("FkItemId");

                    b.ToTable("TB_PEDIDO");
                });

            modelBuilder.Entity("PadariaDoceAroma.Models.Pedido", b =>
                {
                    b.HasOne("PadariaDoceAroma.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("FkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
