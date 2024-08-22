﻿// <auto-generated />
using System;
using EF03.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF03.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Course_Inst", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<double>("Evaluate")
                        .HasColumnType("float");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("course_Insts");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bouns")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Student_Course", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudCourses");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Course_Inst", b =>
                {
                    b.HasOne("EFC01.ITI_DB_Schema.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC01.ITI_DB_Schema.Instructor", "Instructor")
                        .WithMany("InstCourses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Instructor", b =>
                {
                    b.HasOne("EFC01.ITI_DB_Schema.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Student", b =>
                {
                    b.HasOne("EFC01.ITI_DB_Schema.Department", null)
                        .WithMany("Students")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Student_Course", b =>
                {
                    b.HasOne("EFC01.ITI_DB_Schema.Course", "Course")
                        .WithMany("CourseStudent")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC01.ITI_DB_Schema.Student", "Student")
                        .WithMany("student_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Topic", b =>
                {
                    b.HasOne("EFC01.ITI_DB_Schema.Course", null)
                        .WithMany("topic_Courses")
                        .HasForeignKey("CourseID");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Course", b =>
                {
                    b.Navigation("CourseStudent");

                    b.Navigation("topic_Courses");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Instructor", b =>
                {
                    b.Navigation("InstCourses");
                });

            modelBuilder.Entity("EFC01.ITI_DB_Schema.Student", b =>
                {
                    b.Navigation("student_Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
