﻿// <auto-generated />
using EFRELATIONSHIPS.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFRELATIONSHIPS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240529193026_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFRELATIONSHIPS.models.CarCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarCompanies");
                });

            modelBuilder.Entity("EFRELATIONSHIPS.models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarCompanyId")
                        .IsUnique();

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("EFRELATIONSHIPS.models.CarModel", b =>
                {
                    b.HasOne("EFRELATIONSHIPS.models.CarCompany", "CarCompany")
                        .WithOne("CarModel")
                        .HasForeignKey("EFRELATIONSHIPS.models.CarModel", "CarCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarCompany");
                });

            modelBuilder.Entity("EFRELATIONSHIPS.models.CarCompany", b =>
                {
                    b.Navigation("CarModel");
                });
#pragma warning restore 612, 618
        }
    }
}
