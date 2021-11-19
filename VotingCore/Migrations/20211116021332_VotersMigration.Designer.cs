﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingCore.AppDbContext;

namespace VotingCore.Migrations
{
    [DbContext(typeof(EVotingDbContext))]
    [Migration("20211116021332_VotersMigration")]
    partial class VotersMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VotingCore.Models.Make", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("VotingCore.Models.Voters", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contact_number")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("isVoted")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("PanNumber", "Contact_number")
                        .IsUnique()
                        .HasFilter("[PanNumber] IS NOT NULL");

                    b.ToTable("Voters");
                });
#pragma warning restore 612, 618
        }
    }
}