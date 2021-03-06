﻿// <auto-generated />
using CommandsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommandsAPI.Migrations
{
    [DbContext(typeof(CommandsDbContext))]
    partial class CommandsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CommandsAPI.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CommandLine")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("HowTo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Plateform")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("GetCommands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommandLine = "midir FILENAME",
                            HowTo = "Make a dircetory",
                            Plateform = "All Operating Systems"
                        },
                        new
                        {
                            Id = 2,
                            CommandLine = "rmdir FILENAME",
                            HowTo = "Remove a dircetory",
                            Plateform = "All Operating Systems"
                        },
                        new
                        {
                            Id = 3,
                            CommandLine = "echo SOMETHINGTOPRINTE",
                            HowTo = "Print something in Console",
                            Plateform = "All Operating Systems"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
