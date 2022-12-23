﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20221221215554_without_path")]
    partial class withoutpath
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("server.ImageItem", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emotions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Hash")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("ImageId");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
