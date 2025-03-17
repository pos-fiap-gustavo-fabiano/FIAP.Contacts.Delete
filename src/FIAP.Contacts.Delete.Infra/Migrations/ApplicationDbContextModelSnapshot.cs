﻿// <auto-generated />
using System;
using FIAP.Contacts.Delete.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FIAP.Contacts.Delete.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complement")
                        .HasColumnType("text");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Phone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DDD")
                        .HasColumnType("integer");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Address", b =>
                {
                    b.HasOne("FIAP.Contacts.Delete.Domain.ContactAggregate.Contact", "Contact")
                        .WithOne("Address")
                        .HasForeignKey("FIAP.Contacts.Delete.Domain.ContactAggregate.Address", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Phone", b =>
                {
                    b.HasOne("FIAP.Contacts.Delete.Domain.ContactAggregate.Contact", "Contact")
                        .WithOne("Phone")
                        .HasForeignKey("FIAP.Contacts.Delete.Domain.ContactAggregate.Phone", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("FIAP.Contacts.Delete.Domain.ContactAggregate.Contact", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Phone")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
