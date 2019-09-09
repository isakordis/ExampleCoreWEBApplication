﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjeFiles.Models;

namespace ProjeFiles.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20190908213021_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjeFiles.Models.Product", b =>
                {
                    b.Property<Guid>("guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("category");

                    b.Property<string>("name");

                    b.Property<int>("prize");

                    b.HasKey("guid");

                    b.ToTable("products");
                });

            modelBuilder.Entity("ProjeFiles.Models.Users", b =>
                {
                    b.Property<Guid>("guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("userName");

                    b.Property<string>("userPass");

                    b.HasKey("guid");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}