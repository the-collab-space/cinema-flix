﻿// <auto-generated />
using System;
using CinemaFlix.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CinemaFlix.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210408024814_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ActorCharacter", b =>
                {
                    b.Property<Guid>("ActorsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uuid");

                    b.HasKey("ActorsId", "CharactersId");

                    b.HasIndex("CharactersId");

                    b.ToTable("ActorCharacter");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<Guid>("ActorsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.HasKey("CharactersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int?>("Gender")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Announcement")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("interval");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("NUMERIC(2,1)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Synopsis")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ActorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<bool?>("Thumbnail")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<Guid>("DirectorsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.HasKey("DirectorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("DirectorMovie");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<Guid>("GenresId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("ActorCharacter", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .IsRequired();

                    b.HasOne("CinemaFlix.Domain.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .IsRequired();
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .IsRequired();

                    b.HasOne("CinemaFlix.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .IsRequired();

                    b.HasOne("CinemaFlix.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Actor", b =>
                {
                    b.OwnsOne("CinemaFlix.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("ActorId")
                                .HasColumnType("uuid");

                            b1.Property<string>("FirstName")
                                .HasMaxLength(250)
                                .HasColumnType("character varying(250)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("LastName");

                            b1.HasKey("ActorId");

                            b1.ToTable("Actors");

                            b1.WithOwner()
                                .HasForeignKey("ActorId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Character", b =>
                {
                    b.OwnsOne("CinemaFlix.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("CharacterId")
                                .HasColumnType("uuid");

                            b1.Property<string>("FirstName")
                                .HasMaxLength(250)
                                .HasColumnType("character varying(250)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("LastName");

                            b1.HasKey("CharacterId");

                            b1.ToTable("Characters");

                            b1.WithOwner()
                                .HasForeignKey("CharacterId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Director", b =>
                {
                    b.OwnsOne("CinemaFlix.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("DirectorId")
                                .HasColumnType("uuid");

                            b1.Property<string>("FirstName")
                                .HasMaxLength(250)
                                .HasColumnType("character varying(250)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("LastName");

                            b1.HasKey("DirectorId");

                            b1.ToTable("Directors");

                            b1.WithOwner()
                                .HasForeignKey("DirectorId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Language", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Movie", null)
                        .WithMany("Languages")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Movie", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.User", null)
                        .WithMany("Movies")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Picture", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Actor", "Actor")
                        .WithMany("Pictures")
                        .HasForeignKey("ActorId");

                    b.HasOne("CinemaFlix.Domain.Entities.Movie", "Movie")
                        .WithMany("Pictures")
                        .HasForeignKey("MovieId");

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.User", b =>
                {
                    b.OwnsOne("CinemaFlix.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Address")
                                .HasMaxLength(300)
                                .HasColumnType("character varying(300)")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("CinemaFlix.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uuid");

                            b1.Property<string>("FirstName")
                                .HasMaxLength(250)
                                .HasColumnType("character varying(250)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .HasMaxLength(150)
                                .HasColumnType("character varying(150)")
                                .HasColumnName("LastName");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .IsRequired();

                    b.HasOne("CinemaFlix.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("CinemaFlix.Domain.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .IsRequired();

                    b.HasOne("CinemaFlix.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.Movie", b =>
                {
                    b.Navigation("Languages");

                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("CinemaFlix.Domain.Entities.User", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}