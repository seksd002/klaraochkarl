﻿// <auto-generated />
using KlaraKarl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KlaraKarl.Migrations
{
    [DbContext(typeof(KlarakarlDbContext))]
    [Migration("20221226170010_Initial-Commit")]
    partial class InitialCommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("KlaraKarl.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Registred")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "erik9996@hotmail.com",
                            Lastname = "Sköld",
                            Registred = false,
                            Surname = "Erik"
                        },
                        new
                        {
                            Id = 2,
                            Email = "lindapinda@hotmail.com",
                            Lastname = "Sköld",
                            Registred = false,
                            Surname = "Linda"
                        },
                        new
                        {
                            Id = 3,
                            Email = "kenta@live.se",
                            Lastname = "Larsson",
                            Registred = false,
                            Surname = "Kent"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
