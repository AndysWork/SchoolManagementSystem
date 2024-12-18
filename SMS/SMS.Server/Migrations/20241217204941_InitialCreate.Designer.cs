﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.Server.Data;

#nullable disable

namespace SMS.Server.Migrations
{
    [DbContext(typeof(SMSDbContext))]
    [Migration("20241217204941_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SMS.Server.Data.Models.AttendanceLog", b =>
                {
                    b.Property<Guid>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AttendanceDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AttendanceId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("AttendanceLog", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Class", b =>
                {
                    b.Property<Guid>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassId");

                    b.HasIndex("SectionId");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.ClassSchedule", b =>
                {
                    b.Property<Guid>("ClassScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ScheduleTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassScheduleId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassSchedule", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Section", b =>
                {
                    b.Property<Guid>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionId");

                    b.ToTable("Section", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LocalGuardianEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGuardianPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.StudentMark", b =>
                {
                    b.Property<Guid>("MarkEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ObtainedScore")
                        .HasColumnType("int");

                    b.Property<int?>("PassStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MarkEntryId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentMark", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternatePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnlistTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("SMS.Server.Data.Models.AttendanceLog", b =>
                {
                    b.HasOne("SMS.Server.Data.Models.Student", null)
                        .WithMany("AttendanceLogs")
                        .HasForeignKey("StudentId");

                    b.HasOne("SMS.Server.Data.Models.Teacher", null)
                        .WithMany("AttendanceLogs")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Class", b =>
                {
                    b.HasOne("SMS.Server.Data.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.ClassSchedule", b =>
                {
                    b.HasOne("SMS.Server.Data.Models.Class", "Class")
                        .WithMany("ClassSchedules")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Server.Data.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Server.Data.Models.Teacher", "Teacher")
                        .WithMany("ClassSchedules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.StudentMark", b =>
                {
                    b.HasOne("SMS.Server.Data.Models.Student", "Student")
                        .WithMany("StudentMarks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Server.Data.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Class", b =>
                {
                    b.Navigation("ClassSchedules");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Student", b =>
                {
                    b.Navigation("AttendanceLogs");

                    b.Navigation("StudentMarks");
                });

            modelBuilder.Entity("SMS.Server.Data.Models.Teacher", b =>
                {
                    b.Navigation("AttendanceLogs");

                    b.Navigation("ClassSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
