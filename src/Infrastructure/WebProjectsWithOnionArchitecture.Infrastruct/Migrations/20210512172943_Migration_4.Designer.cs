﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProjectsWithOnionArchitecture.Persist.DbContext;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210512172943_Migration_4")]
    partial class Migration_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CrmUserGuid")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.HasIndex("CrmUserGuid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmAccount", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Accountid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OdataEtag")
                        .HasColumnType("TEXT");

                    b.Property<int>("Statecode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Guid");

                    b.ToTable("CrmAccount");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmTask", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegardingObjectidSalesOrderOdataBind")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Scheduledend")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryOfTask")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("CrmTask");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmUser", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BusinessUnitId")
                        .HasColumnType("TEXT");

                    b.Property<string>("OdataContext")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("CrmUser");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities.User", b =>
                {
                    b.HasOne("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmUser", "CrmUser")
                        .WithMany("Users")
                        .HasForeignKey("CrmUserGuid");

                    b.Navigation("CrmUser");
                });

            modelBuilder.Entity("WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities.CrmUser", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
