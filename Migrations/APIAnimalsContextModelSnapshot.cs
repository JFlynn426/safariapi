﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using safariapi;

namespace safariapi.Migrations
{
    [DbContext(typeof(APIAnimalsContext))]
    partial class APIAnimalsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("safariapi.Models.APIAnimals", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfTimesSeen");

                    b.Property<string>("LocationOfLastSeen");

                    b.Property<string>("Species");

                    b.HasKey("ID");

                    b.ToTable("APIAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}