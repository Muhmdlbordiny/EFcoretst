﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testscaffold.Additional;

#nullable disable

namespace testscaffold.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240130132538_four")]
    partial class four
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("DeliveryOrder")
                .StartsAt(101L);

            modelBuilder.Entity("testscaffold.Additional.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The dadsdsd ");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("theData")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("studentId");

                    b.ToTable("StudentsAtts", "std");
                });

            modelBuilder.Entity("testscaffold.Additional.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("Next Value For DeliveryOrder");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("testscaffold.Additional.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("des")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("testscaffold.Additional.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("genderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            genderName = "Male"
                        },
                        new
                        {
                            Id = 2,
                            genderName = "Female"
                        });
                });

            modelBuilder.Entity("testscaffold.Additional.Grade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("chemistry")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("physics")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("programming")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("studentid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("studentid")
                        .IsUnique()
                        .HasFilter("[studentid] IS NOT NULL");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("testscaffold.Additional.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("createdDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[customerTitle] + ' ' + [customerName]");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(1m);

                    b.Property<decimal>("total")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("[price] * [qty]");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("testscaffold.Additional.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("testscaffold.Additional.StudentBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("getDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookId");

                    b.HasIndex("studentId");

                    b.ToTable("StudentBooks");
                });

            modelBuilder.Entity("testscaffold.Additional.Uniform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("Next Value For DeliveryOrder");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("uniforms");
                });

            modelBuilder.Entity("testscaffold.Additional.Attendance", b =>
                {
                    b.HasOne("testscaffold.Additional.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("student");
                });

            modelBuilder.Entity("testscaffold.Additional.Grade", b =>
                {
                    b.HasOne("testscaffold.Additional.Student", "student")
                        .WithOne("grade")
                        .HasForeignKey("testscaffold.Additional.Grade", "studentid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("student");
                });

            modelBuilder.Entity("testscaffold.Additional.Student", b =>
                {
                    b.HasOne("testscaffold.Additional.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("testscaffold.Additional.StudentBook", b =>
                {
                    b.HasOne("testscaffold.Additional.Book", "book")
                        .WithMany("Students")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("testscaffold.Additional.Student", "student")
                        .WithMany("books")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("student");
                });

            modelBuilder.Entity("testscaffold.Additional.Book", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("testscaffold.Additional.Department", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("testscaffold.Additional.Student", b =>
                {
                    b.Navigation("books");

                    b.Navigation("grade")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
