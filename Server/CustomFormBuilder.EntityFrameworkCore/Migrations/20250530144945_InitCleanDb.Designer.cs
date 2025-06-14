﻿// <auto-generated />
using System;
using CustomFormBuilder.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomFormBuilder.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(CustomFormBuilderDbContext))]
    [Migration("20250530144945_InitCleanDb")]
    partial class InitCleanDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomFormBuilder.Domain.FormControlOptions.FormControlOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FormControlId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormControlId");

                    b.ToTable("FormControlOptions");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormControls.FormControl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormVersionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormVersionId");

                    b.ToTable("FormControls");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormSubmissionValues.FormSubmissionValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormControlId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormSubmissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormControlId");

                    b.HasIndex("FormSubmissionId");

                    b.ToTable("FormSubmissionValues");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormVersions.FormVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("FormVersions");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.Forms.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("FormSubmission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormVersionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FormVersionId");

                    b.ToTable("FormSubmissions");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormControlOptions.FormControlOption", b =>
                {
                    b.HasOne("CustomFormBuilder.Domain.FormControls.FormControl", "FormControl")
                        .WithMany("Options")
                        .HasForeignKey("FormControlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormControl");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormControls.FormControl", b =>
                {
                    b.HasOne("CustomFormBuilder.Domain.FormVersions.FormVersion", "FormVersion")
                        .WithMany("Controls")
                        .HasForeignKey("FormVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormVersion");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormSubmissionValues.FormSubmissionValue", b =>
                {
                    b.HasOne("CustomFormBuilder.Domain.FormControls.FormControl", "FormControl")
                        .WithMany("SubmissionValues")
                        .HasForeignKey("FormControlId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FormSubmission", "FormSubmission")
                        .WithMany("Values")
                        .HasForeignKey("FormSubmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormControl");

                    b.Navigation("FormSubmission");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormVersions.FormVersion", b =>
                {
                    b.HasOne("CustomFormBuilder.Domain.Forms.Form", "Form")
                        .WithMany("Versions")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("FormSubmission", b =>
                {
                    b.HasOne("CustomFormBuilder.Domain.FormVersions.FormVersion", "FormVersion")
                        .WithMany()
                        .HasForeignKey("FormVersionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FormVersion");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormControls.FormControl", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("SubmissionValues");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.FormVersions.FormVersion", b =>
                {
                    b.Navigation("Controls");
                });

            modelBuilder.Entity("CustomFormBuilder.Domain.Forms.Form", b =>
                {
                    b.Navigation("Versions");
                });

            modelBuilder.Entity("FormSubmission", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
