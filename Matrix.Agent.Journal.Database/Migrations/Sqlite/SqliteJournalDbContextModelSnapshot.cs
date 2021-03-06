﻿// <auto-generated />
using Matrix.Agent.Journal.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Matrix.Agent.Journal.Database.Migrations.Sqlite
{
    [DbContext(typeof(SqliteJournalDbContext))]
    partial class SqliteJournalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Matrix.Agent.Journal.Database.Entities.LogEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Application");

                    b.Property<int>("Event");

                    b.Property<int>("Level");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(4096);

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Matrix.Agent.Journal.Database.Entities.LogProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid?>("LogEntryId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("LogEntryId");

                    b.ToTable("LogProperty");
                });

            modelBuilder.Entity("Matrix.Agent.Journal.Database.Entities.LogTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LogEntryId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("LogEntryId");

                    b.ToTable("LogTag");
                });

            modelBuilder.Entity("Matrix.Agent.Journal.Database.Entities.LogProperty", b =>
                {
                    b.HasOne("Matrix.Agent.Journal.Database.Entities.LogEntry")
                        .WithMany("Properties")
                        .HasForeignKey("LogEntryId");
                });

            modelBuilder.Entity("Matrix.Agent.Journal.Database.Entities.LogTag", b =>
                {
                    b.HasOne("Matrix.Agent.Journal.Database.Entities.LogEntry")
                        .WithMany("Tags")
                        .HasForeignKey("LogEntryId");
                });
#pragma warning restore 612, 618
        }
    }
}
