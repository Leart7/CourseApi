﻿// <auto-generated />
using System;
using CourseApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240319033053_ExtraPropertiesNullable")]
    partial class ExtraPropertiesNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CourseApi.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Lessons")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("Ratings")
                        .HasColumnType("float");

                    b.Property<int?>("Reviews")
                        .HasColumnType("int");

                    b.Property<double?>("RuntTime")
                        .HasColumnType("float");

                    b.Property<string>("SkillLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Students")
                        .HasColumnType("int");

                    b.Property<string>("Teacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Video_Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CourseApi.Models.Course", b =>
                {
                    b.HasOne("CourseApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
