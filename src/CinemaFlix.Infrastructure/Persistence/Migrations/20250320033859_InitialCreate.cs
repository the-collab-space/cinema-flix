using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CinemaFlix.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    birth_date = table.Column<LocalDate>(type: "date", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    name_first_name = table.Column<string>(type: "text", nullable: false),
                    name_last_name = table.Column<string>(type: "text", nullable: false),
                    create_date = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    update_date = table.Column<Instant>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_actors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "directors",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    birth_date = table.Column<LocalDate>(type: "date", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    name_first_name = table.Column<string>(type: "text", nullable: false),
                    name_last_name = table.Column<string>(type: "text", nullable: false),
                    create_date = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    update_date = table.Column<Instant>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_directors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    synopsis = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    adult = table.Column<bool>(type: "boolean", nullable: false),
                    release_date = table.Column<LocalDate>(type: "date", nullable: false),
                    duration = table.Column<TimeSpan>(type: "interval", nullable: true),
                    rating = table.Column<float>(type: "numeric(3,1)", nullable: true),
                    create_date = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    update_date = table.Column<Instant>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    favorite_movies_ids = table.Column<Guid[]>(type: "uuid[]", nullable: false),
                    watch_list_ids = table.Column<Guid[]>(type: "uuid[]", nullable: false),
                    email_address = table.Column<string>(type: "text", nullable: false),
                    name_first_name = table.Column<string>(type: "text", nullable: false),
                    name_last_name = table.Column<string>(type: "text", nullable: false),
                    create_date = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    update_date = table.Column<Instant>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "actor_movie",
                columns: table => new
                {
                    actors_id = table.Column<Guid>(type: "uuid", nullable: false),
                    movies_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_actor_movie", x => new { x.actors_id, x.movies_id });
                    table.ForeignKey(
                        name: "fk_actor_movie_actors_actors_id",
                        column: x => x.actors_id,
                        principalTable: "actors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_actor_movie_movies_movies_id",
                        column: x => x.movies_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "director_movie",
                columns: table => new
                {
                    directors_id = table.Column<Guid>(type: "uuid", nullable: false),
                    movies_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_director_movie", x => new { x.directors_id, x.movies_id });
                    table.ForeignKey(
                        name: "fk_director_movie_directors_directors_id",
                        column: x => x.directors_id,
                        principalTable: "directors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_director_movie_movies_movies_id",
                        column: x => x.movies_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    movie_id = table.Column<Guid>(type: "uuid", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_genre", x => new { x.movie_id, x.id });
                    table.ForeignKey(
                        name: "fk_genre_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    rating = table.Column<float>(type: "numeric(3,1)", nullable: false),
                    movie_id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    create_date = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    update_date = table.Column<Instant>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reviews", x => x.id);
                    table.ForeignKey(
                        name: "fk_reviews_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reviews_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_actor_movie_movies_id",
                table: "actor_movie",
                column: "movies_id");

            migrationBuilder.CreateIndex(
                name: "ix_director_movie_movies_id",
                table: "director_movie",
                column: "movies_id");

            migrationBuilder.CreateIndex(
                name: "ix_reviews_movie_id",
                table: "reviews",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "ix_reviews_user_id",
                table: "reviews",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actor_movie");

            migrationBuilder.DropTable(
                name: "director_movie");

            migrationBuilder.DropTable(
                name: "genre");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "directors");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
