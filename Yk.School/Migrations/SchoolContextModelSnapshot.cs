﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Yk.School.EntityFramework;
using Yk.School.Models;

namespace Yk.School.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Yk.School.Models.DanceClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InstructorId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("DanceClass");
                });

            modelBuilder.Entity("Yk.School.Models.FeeHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<DateTime>("FeeDate");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("FeeHistory");
                });

            modelBuilder.Entity("Yk.School.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContantNumber");

                    b.Property<string>("Email");

                    b.Property<string>("RealName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("Yk.School.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Class")
                        .HasMaxLength(50);

                    b.Property<string>("ContantNumber")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("CurrentSchool")
                        .HasMaxLength(200);

                    b.Property<int>("DanceClassId");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("Grade")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastFeeDate");

                    b.Property<string>("ParentsName")
                        .HasMaxLength(50);

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Sex");

                    b.Property<decimal>("TotalFeeAmount");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DanceClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Yk.School.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Yk.School.Models.DanceClass", b =>
                {
                    b.HasOne("Yk.School.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Yk.School.Models.FeeHistory", b =>
                {
                    b.HasOne("Yk.School.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Yk.School.Models.Student", b =>
                {
                    b.HasOne("Yk.School.Models.DanceClass", "DanceClass")
                        .WithMany()
                        .HasForeignKey("DanceClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Yk.School.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}