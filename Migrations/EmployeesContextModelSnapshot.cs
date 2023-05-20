﻿// <auto-generated />
using System;
using AcoWeb.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcoWeb.API.Migrations
{
    [DbContext(typeof(EmployeesContext))]
    partial class EmployeesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcoWeb.API.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<DateTimeOffset>("HireDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<Guid>("OfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleInCompany")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salary")
                        .HasMaxLength(35)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6978cc16-5f5a-4020-bb79-4cc4dcc36b72"),
                            FirstName = "Antonio",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "P Summers",
                            OfficeId = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            RoleInCompany = "Manager",
                            Salary = 200000m
                        },
                        new
                        {
                            Id = new Guid("4fa3169e-0779-45cc-9139-dc4ee92cbd5f"),
                            FirstName = "Colton",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Minton",
                            OfficeId = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            RoleInCompany = "Backend developer",
                            Salary = 190000m
                        },
                        new
                        {
                            Id = new Guid("3675f42d-9bbb-488f-bd36-c7e6411c87d5"),
                            FirstName = "Crystal",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Krupa",
                            OfficeId = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            RoleInCompany = "Developer",
                            Salary = 420000m
                        },
                        new
                        {
                            Id = new Guid("ea3a236e-fda4-4e3f-ae1d-3bd3a535a177"),
                            FirstName = "Caitlin",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Nicholson",
                            OfficeId = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            RoleInCompany = "Sellman",
                            Salary = 100000m
                        },
                        new
                        {
                            Id = new Guid("270ed53a-053b-442a-9302-716959d0a51a"),
                            FirstName = "Kristi",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Mauricio",
                            OfficeId = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            RoleInCompany = "Credit officer",
                            Salary = 200000m
                        },
                        new
                        {
                            Id = new Guid("b1ee8f72-0cc0-4cd9-bcc6-11183cf24da8"),
                            FirstName = "Thomas",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Spates",
                            OfficeId = new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"),
                            RoleInCompany = "Sellman",
                            Salary = 200000m
                        },
                        new
                        {
                            Id = new Guid("d447d3e9-82d3-4aba-80ae-223a6683f5c3"),
                            FirstName = "Pattie",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Foster",
                            OfficeId = new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"),
                            RoleInCompany = "Sellman",
                            Salary = 400000m
                        },
                        new
                        {
                            Id = new Guid("c5dceee6-ab09-42ab-bc30-cb0e91114b3d"),
                            FirstName = "Candy",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Gilbert",
                            OfficeId = new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"),
                            RoleInCompany = "Web developer",
                            Salary = 500000m
                        },
                        new
                        {
                            Id = new Guid("85cbcd1f-8b72-4398-b2fe-b2776ab0be0f"),
                            FirstName = "Jessica",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Gibbs",
                            OfficeId = new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"),
                            RoleInCompany = "Manager",
                            Salary = 200000m
                        },
                        new
                        {
                            Id = new Guid("8588c7bf-2bd4-436a-a1fc-9c790895b9d5"),
                            FirstName = "Rhonda",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Macklin",
                            OfficeId = new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"),
                            RoleInCompany = "Backend developer",
                            Salary = 190000m
                        },
                        new
                        {
                            Id = new Guid("c3f4100c-f746-467b-ab9e-4c16361a44af"),
                            FirstName = "Willie",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Overton",
                            OfficeId = new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"),
                            RoleInCompany = "Head Of Developers",
                            Salary = 12500000m
                        },
                        new
                        {
                            Id = new Guid("d11d3a8d-30b6-4b3a-ad9b-ab2141a2f6bb"),
                            FirstName = "Gary",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Owens",
                            OfficeId = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            RoleInCompany = "Sellman",
                            Salary = 100000m
                        },
                        new
                        {
                            Id = new Guid("5c0bd7ac-a87b-4e92-81bb-14de6fdc6808"),
                            FirstName = "Bart",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Burgess",
                            OfficeId = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            RoleInCompany = "Credit officer",
                            Salary = 250000m
                        },
                        new
                        {
                            Id = new Guid("217cfe3f-f278-4ce8-84de-d9d523ca3802"),
                            FirstName = "Diane",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Perry",
                            OfficeId = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            RoleInCompany = "Sellman",
                            Salary = 100000m
                        },
                        new
                        {
                            Id = new Guid("532c9736-4fb6-4a4d-aa8f-e7a2d6a4ca49"),
                            FirstName = "Sarah",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Crews",
                            OfficeId = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            RoleInCompany = "Sellman",
                            Salary = 240000m
                        },
                        new
                        {
                            Id = new Guid("f3ad3974-0c05-4db0-bda0-dee18f00a291"),
                            FirstName = "Catherine",
                            HireDate = new DateTimeOffset(new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LastName = "Easley",
                            OfficeId = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            RoleInCompany = "Web developer",
                            Salary = 100000m
                        });
                });

            modelBuilder.Entity("AcoWeb.API.Entities.EmployeeAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeAddress");
                });

            modelBuilder.Entity("AcoWeb.API.Entities.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ab77607-42e8-4a25-b47a-db8983a652e8"),
                            Address = "1492 Brentwood Drive",
                            Name = "Oscar"
                        },
                        new
                        {
                            Id = new Guid("ca2abc8e-1bdc-4887-8f97-215fe050f22f"),
                            Address = "3406 Thrash Trail",
                            Name = "Maud"
                        },
                        new
                        {
                            Id = new Guid("d097a599-4619-4473-ae86-d353c3069597"),
                            Address = "784 Byers Lanet",
                            Name = "Redding"
                        },
                        new
                        {
                            Id = new Guid("99bc7e9d-9033-4752-a3db-a577447a7df3"),
                            Address = "1698 Brown Street d",
                            Name = "Payson"
                        },
                        new
                        {
                            Id = new Guid("170ff47b-290a-4b22-acf7-8e265afeafb5"),
                            Address = "	876 Chicago Avenue",
                            Name = "Lindsay"
                        },
                        new
                        {
                            Id = new Guid("a228f20b-7458-4a8c-95ba-4b209965d677"),
                            Address = "1641 Granville Lane",
                            Name = "Newark"
                        },
                        new
                        {
                            Id = new Guid("7c862b39-c6d1-4c91-8181-c6cc35890bca"),
                            Address = "1477 Liberty Street",
                            Name = "WASHINGTON"
                        });
                });

            modelBuilder.Entity("AcoWeb.API.Entities.Employee", b =>
                {
                    b.HasOne("AcoWeb.API.Entities.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });

            modelBuilder.Entity("AcoWeb.API.Entities.EmployeeAddress", b =>
                {
                    b.HasOne("AcoWeb.API.Entities.Employee", "Employee")
                        .WithOne("EmployeeAddress")
                        .HasForeignKey("AcoWeb.API.Entities.EmployeeAddress", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AcoWeb.API.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeAddress");
                });

            modelBuilder.Entity("AcoWeb.API.Entities.Office", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
