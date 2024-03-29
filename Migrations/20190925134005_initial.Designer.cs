﻿// <auto-generated />
using System;
using Audify.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Audify.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190925134005_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Audify.Model.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductShortCode");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Audify.Model.ProductCategory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Audify.Model.Provider", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProviderCategoryId");

                    b.Property<string>("ProviderName");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Audify.Model.Transactions", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountId");

                    b.Property<double>("Amount");

                    b.Property<string>("BatchId");

                    b.Property<int>("ChannelId");

                    b.Property<string>("ProductCategoryId");

                    b.Property<string>("ProductId");

                    b.Property<string>("ProviderId");

                    b.Property<string>("SubscriptionId");

                    b.Property<int>("TimeOfTheWeek");

                    b.Property<DateTime>("TransDay");

                    b.Property<string>("Value");

                    b.Property<int>("mode");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Audify.Model.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessName");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
