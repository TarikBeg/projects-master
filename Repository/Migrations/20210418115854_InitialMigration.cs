using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CastActors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastActors_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastMovies_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatingMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingMovies_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastTvShows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastTvShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastTvShows_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastTvShows_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingTvShows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingTvShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatingTvShows_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatingTvShows_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(4538), "Brad", "Pit", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(4543) },
                    { new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6152), "Peter", "Dinklage", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6157) },
                    { new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6172), "Lena", "Headey", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6173) },
                    { new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6178), "Emilia", "Clarke", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6179) },
                    { new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6183), "Kit", "Harington", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6184) },
                    { new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6188), "Sophie", "Turner", new DateTime(2021, 4, 18, 11, 58, 53, 686, DateTimeKind.Utc).AddTicks(6189) }
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2720), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2720) },
                    { new Guid("45712daf-7f0e-47a4-8116-d84268109177"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2723), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2723) },
                    { new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2726), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2727) },
                    { new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2729), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2730) },
                    { new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2732), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2733) },
                    { new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2741), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2742) },
                    { new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2738), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2739) },
                    { new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2716), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2717) },
                    { new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2744), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2745) },
                    { new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2747), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2748) },
                    { new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2750), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2750) },
                    { new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2735), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2736) },
                    { new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2713), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2714) },
                    { new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2710), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2711) },
                    { new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2707), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2708) },
                    { new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2638), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2641) },
                    { new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2670), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2671) },
                    { new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2675), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2675) },
                    { new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2682), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2683) },
                    { new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2685), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2686) },
                    { new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2678), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2679) },
                    { new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2691), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2692) },
                    { new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2694), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2695) },
                    { new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2698), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2698) },
                    { new Guid("71033605-948c-4cdd-af69-9f026440105d"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2701), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2702) },
                    { new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2704), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2705) },
                    { new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2688), new DateTime(2021, 4, 18, 11, 58, 53, 692, DateTimeKind.Utc).AddTicks(2689) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AverageRating", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"), 4.5999999999999996, "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheFellowshipoftheRing.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7934), "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7935), new DateTime(2001, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring" },
                    { new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e"), 1.0, "https://mistraltask.blob.core.windows.net/mistraltask/StarWarsEpisodeVTheEmpireStrikesBack.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7979), "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader and a bounty hunter named Boba Fett all over the galaxy.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7979), new DateTime(1980, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V - The Empire Strikes Back" },
                    { new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682"), 2.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheTwoTowers.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7970), "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7971), new DateTime(2002, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Two Towers" },
                    { new Guid("f98499a3-00a6-4335-a175-53a30b5b7246"), 3.0, "https://mistraltask.blob.core.windows.net/mistraltask/Inception.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7961), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7962), new DateTime(2010, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655"), 3.0, "https://mistraltask.blob.core.windows.net/mistraltask/ForrestGump.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7952), "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7953), new DateTime(1994, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"), 3.2000000000000002, "https://mistraltask.blob.core.windows.net/mistraltask/FightClub.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7943), "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7944), new DateTime(1999, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"), 4.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheGoodtheBadandtheUgly.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7925), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7926), new DateTime(1966, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly" },
                    { new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2"), 8.0, "https://mistraltask.blob.core.windows.net/mistraltask/12AngryMen.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7888), "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7889), new DateTime(1957, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men" },
                    { new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"), 7.0, "https://mistraltask.blob.core.windows.net/mistraltask/PulpFiction.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7907), "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7908), new DateTime(1994, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AverageRating", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"), 7.0, "https://mistraltask.blob.core.windows.net/mistraltask/SchindlerList.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7898), "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7899), new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"), 0.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheReturnoftheKing.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7916), "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7917), new DateTime(2003, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King" },
                    { new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"), 8.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheDarkKnight.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7878), "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7879), new DateTime(2008, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("db03a785-ffbb-4599-9add-763ae9156d83"), 9.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheGodfatherPartII.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7863), "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7865), new DateTime(1972, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II" },
                    { new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"), 10.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheGodfather.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7840), "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(7845), new DateTime(1972, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), 10.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheShawshankRedemption.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(3998), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", new DateTime(2021, 4, 18, 11, 58, 53, 676, DateTimeKind.Utc).AddTicks(4010), new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), " The Shawshank Redemption" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Star" },
                values: new object[,]
                {
                    { new Guid("53ee0e5a-70be-4c6f-8e65-b908ed399ee5"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4390), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4391), 5 },
                    { new Guid("6ca7dcad-8db9-4956-ba9b-7c53f00cd69a"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4387), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4388), 3 },
                    { new Guid("62480509-2c97-473f-bbe9-c097a4c46f5f"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4384), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4384), 2 },
                    { new Guid("704cd083-5dea-4599-a95a-618687fcd5fe"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4380), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4381), 1 },
                    { new Guid("7235e79b-3794-4d03-a78c-cf724772778b"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4376), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4377), 6 },
                    { new Guid("9baacbc3-8000-46e5-b57f-f664bb35e456"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4321), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4322), 3 },
                    { new Guid("b6410b02-82b2-4244-8445-442de29908d3"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4324), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4325), 6 },
                    { new Guid("19d162da-67fa-4712-8d4f-3bffc4d83d47"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4394), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4394), 10 },
                    { new Guid("00363923-b800-4958-8e73-a3ae096453d9"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4317), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4318), 3 },
                    { new Guid("1109cbd5-93ef-4145-a29a-32ae758bf92c"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4314), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4314), 3 },
                    { new Guid("0cd3fefc-968d-4387-a657-5308ea1e78e4"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4310), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4311), 1 },
                    { new Guid("5f7ef726-22d2-4f7e-80f4-1ab24c3c26a9"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4328), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4328), 6 },
                    { new Guid("510e4555-d700-4284-8a12-27569c80a98f"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4397), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4398), 10 },
                    { new Guid("bdfa3907-806f-4932-b974-63c9f56f76cf"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4408), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4409), 9 },
                    { new Guid("8caf4fc5-f4af-4fa9-a00b-d6ae1b98833a"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4404), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4405), 9 },
                    { new Guid("d6892c99-c8eb-4fc9-845f-98340576d868"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4412), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4412), 9 },
                    { new Guid("03bed403-761f-4c26-85b7-0f45b9cfdd18"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4415), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4416), 8 },
                    { new Guid("52f05984-2671-4482-ab52-63585f5cc9dd"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4418), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4419), 8 },
                    { new Guid("d4f5c5cd-c093-44f5-8cb3-cad53c281aac"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4422), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4423), 7 },
                    { new Guid("522eb814-935f-4ba6-90ef-2309e3e6b1c6"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4426), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4426), 6 },
                    { new Guid("2dc113d1-c9bc-48f9-b18e-b62381ff853a"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4429), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4430), 6 },
                    { new Guid("46632975-c0d8-471b-ada2-7a5fe6c3b4af"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4432), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4433), 6 },
                    { new Guid("0b72821c-2c78-46de-8eae-7c2bf1573e4c"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4436), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4437), 5 },
                    { new Guid("9f296723-66a5-403c-9d98-e21650f88ce4"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4440), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4440), 4 },
                    { new Guid("abe5c938-b5cd-4dbd-9602-b7ce2c31d232"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4443), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4444), 4 },
                    { new Guid("3d455335-0b64-4220-8efb-5508fe1336fc"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4306), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4307), 2 },
                    { new Guid("853a954d-652b-4e12-9aff-88585f53fa32"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4401), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4402), 10 },
                    { new Guid("cb7ae9bc-1abc-4712-9a8b-dc7ad52f311d"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4303), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4303), 7 },
                    { new Guid("aa87369c-2cde-44e3-a6b2-0ee7863005c4"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4239), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4240), 10 },
                    { new Guid("b110b30c-67dc-43c4-81bf-1208a921f27f"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4296), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4297), 8 },
                    { new Guid("76a4eaa4-25a8-4469-93ea-08ccd05a60ae"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(1986), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(1991), 10 },
                    { new Guid("c34e4947-510b-4083-ae7a-8040c623bc2e"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4197), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4200), 10 },
                    { new Guid("6ac06f71-b7fb-4c1f-b6d6-014faf2be2b6"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4214), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4214), 9 },
                    { new Guid("fa7af4e4-aa07-47d0-9bdd-241d899f0d43"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4218), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4219), 10 },
                    { new Guid("9017f600-9bf3-48df-851c-a988fbf538ca"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4222), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4222), 6 },
                    { new Guid("7009d22f-43bc-4b75-8063-99c6ef7f73c7"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4225), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4226), 8 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Star" },
                values: new object[,]
                {
                    { new Guid("d635273d-e4ae-4c80-bf3f-423daf6ef44c"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4229), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4230), 10 },
                    { new Guid("d452ee9c-7f5e-46ac-9ff7-243997b3e463"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4299), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4300), 5 },
                    { new Guid("bdd9f99a-0ce7-48f2-ad91-dd7b2bf54a0a"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4236), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4236), 8 },
                    { new Guid("60d0ff04-a35e-4580-a1f8-981ef6b72675"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4243), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4243), 5 },
                    { new Guid("33c0c66c-65db-4c6d-b65b-8453ca9c36a4"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4246), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4247), 10 },
                    { new Guid("92fde2b4-2f7e-4713-873e-3e19b3d00380"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4249), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4250), 7 },
                    { new Guid("d9acba2e-cfd8-47ef-82b6-35f29bcf0f72"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4232), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4233), 7 },
                    { new Guid("ec0157b5-7919-4093-a2ff-5edfd5b2e579"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4256), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4257), 9 },
                    { new Guid("dd4e4db2-4cfe-4174-b668-9255234867cb"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4253), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4254), 9 },
                    { new Guid("5beaf703-85ff-4272-aeb9-6ec279cf5417"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4290), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4290), 8 },
                    { new Guid("6e0fed50-8009-40cd-bbef-fa668abffd9e"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4286), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4287), 7 },
                    { new Guid("92353641-44ee-4bd6-a75f-c3dc0d8ed456"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4283), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4284), 6 },
                    { new Guid("7d7cf2c1-6d67-4b3b-9db6-10ee12e2f85b"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4280), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4280), 10 },
                    { new Guid("b4319a50-d682-4944-af47-369c79a879bd"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4276), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4277), 7 },
                    { new Guid("29b91bf0-cee2-46ad-9f05-ff01382faf84"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4293), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4294), 4 },
                    { new Guid("a5f4fef1-f6ff-4d19-8298-2987bb522d50"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4269), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4270), 4 },
                    { new Guid("41914417-576b-4177-8c91-a706b2402aa4"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4266), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4267), 3 },
                    { new Guid("510b4e8e-33eb-4103-a29a-d7cfe3bd1b84"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4263), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4264), 7 },
                    { new Guid("109ae507-d931-4fa5-b842-83bbf14af8e3"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4260), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4260), 6 },
                    { new Guid("50fad2c1-ec6f-4a22-9cf7-ac22ed7b7ba8"), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4273), new DateTime(2021, 4, 18, 11, 58, 53, 698, DateTimeKind.Utc).AddTicks(4274), 2 }
                });

            migrationBuilder.InsertData(
                table: "TvShows",
                columns: new[] { "Id", "AverageRating", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5"), 4.0, "https://mistraltask.blob.core.windows.net/mistraltask/Cosmos1980.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6122), "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6122), new DateTime(1980, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos" },
                    { new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d"), 4.0, "https://mistraltask.blob.core.windows.net/mistraltask/Cosmos.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6117), "An exploration of our discovery of the laws of nature and coordinates in space and time.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6117), new DateTime(2014, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos" },
                    { new Guid("5e47a903-c741-4c69-a946-576a62178499"), 5.0, "https://mistraltask.blob.core.windows.net/mistraltask/OurPlanet.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6113), "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6113), new DateTime(2019, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Planet" },
                    { new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c"), 6.0, "https://mistraltask.blob.core.windows.net/mistraltask/TheWire.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6108), "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6109), new DateTime(2002, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wire" },
                    { new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f"), 7.0, "https://mistraltask.blob.core.windows.net/mistraltask/BluePlanetII.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6103), "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6104), new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blue Planet II" },
                    { new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431"), 9.0, "https://mistraltask.blob.core.windows.net/mistraltask/BreakingBad.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6094), "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6094), new DateTime(2008, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad" },
                    { new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc"), 9.0, "https://mistraltask.blob.core.windows.net/mistraltask/BandofBrothers.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6088), "The story of Easy Company of the U.S. Army 101st Airborne Division, and their mission in World War II Europe, from Operation Overlord, through V-J Day.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6089), new DateTime(2001, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers" },
                    { new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"), 10.0, "https://mistraltask.blob.core.windows.net/mistraltask/PlanetEarth.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6071), "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6074), new DateTime(2006, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth" },
                    { new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"), 10.0, "https://mistraltask.blob.core.windows.net/mistraltask/PlanetEarthII.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(3524), "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(3531), new DateTime(2016, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth II" },
                    { new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce"), 4.0, "https://mistraltask.blob.core.windows.net/mistraltask/AvatarTheLastAirbender.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6126), "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6127), new DateTime(2005, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: The Last Airbender" },
                    { new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce"), 8.0, "https://mistraltask.blob.core.windows.net/mistraltask/Chernobyl.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6099), "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6099), new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), " Chernobyl" },
                    { new Guid("34a59d35-558c-4183-99b9-0457652f8663"), 3.0, "https://mistraltask.blob.core.windows.net/mistraltask/GameofThrones.jpg", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6131), "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", new DateTime(2021, 4, 18, 11, 58, 53, 682, DateTimeKind.Utc).AddTicks(6131), new DateTime(2011, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones" }
                });

            migrationBuilder.InsertData(
                table: "CastActors",
                columns: new[] { "Id", "ActorId", "CastId", "CreatedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("d3940e55-c01f-4322-818b-85e8c1e69995"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(6496), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(6504) },
                    { new Guid("3a4bd340-1112-4af8-80fc-10490a082a1b"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8027), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8028) },
                    { new Guid("b13d156e-c3c7-4c30-bf7a-b3a886786563"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8034), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8035) },
                    { new Guid("198e0698-5965-4ee6-8a5a-8dffca9f514a"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8040), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8041) },
                    { new Guid("77b6d180-8e8d-4f50-846d-174415ce2eee"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8046), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8046) },
                    { new Guid("c40ccfef-9b7e-4d79-859f-bc61c1e30e0f"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("45712daf-7f0e-47a4-8116-d84268109177"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8051), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8052) },
                    { new Guid("ddd42203-0439-49fb-8ffa-e527c0478e41"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("45712daf-7f0e-47a4-8116-d84268109177"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8057), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8058) },
                    { new Guid("a2a1e81f-c63d-4e74-bbe1-1557533bea84"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8062), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8063) },
                    { new Guid("c519a4b9-0d5f-4564-9e76-10cb7c583f59"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8068), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8069) },
                    { new Guid("7ba4a07e-abc0-4e3d-8cf6-7f3a6564c657"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8074), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8075) },
                    { new Guid("4d58170f-bb87-452e-bcaa-916fa10270e2"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8079), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8080) },
                    { new Guid("1bfb8dd8-f700-4c69-8e4f-fc1dc8d76ca2"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8084), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8085) },
                    { new Guid("a4b9c47a-b530-4f6f-84af-7e7981085618"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8015), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8016) },
                    { new Guid("35a861fc-5328-4178-9299-3d19407ba451"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8090), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8091) },
                    { new Guid("c949749a-a7f1-4fa0-a616-330d9a4362d6"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8100), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8101) },
                    { new Guid("611ca1d4-9457-4a1e-825e-414263e63cab"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8106), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8107) },
                    { new Guid("b40311b4-cee0-4df1-a8f4-bc6104369e52"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8112), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8112) },
                    { new Guid("df600a1d-a9c4-4255-8076-ab9e225573e9"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8117), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8118) },
                    { new Guid("d76f0119-dd08-437a-b018-f3ec8c2a52cc"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8122), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8123) },
                    { new Guid("ed547ac9-9cbb-4376-9706-7c168da0f224"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8128), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8129) },
                    { new Guid("f99f2662-3603-4c4b-b32f-0a216aeab9ad"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8134), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8134) },
                    { new Guid("cec6e9e5-94bb-49d5-bc85-ae050cfd8f2d"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8139), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8140) },
                    { new Guid("1d6a882f-7d0a-4b93-ad87-d89807320db5"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8145), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8145) },
                    { new Guid("506062ab-4155-42f2-a7a9-8e28c79a9513"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8150), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8151) },
                    { new Guid("08ab9542-30cd-4b17-8084-5a2e23ac3ca9"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8155), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8156) },
                    { new Guid("432bf952-a3f3-4174-96e1-4994969f219b"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8095), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8096) },
                    { new Guid("76f4d432-738c-42cc-a9ac-8b38dc8ed585"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8010), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8011) },
                    { new Guid("46cbb4f1-c660-4626-bfca-452ae3cbfe65"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8022), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8022) },
                    { new Guid("a642784a-f507-4605-a924-4406cc8acc78"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7999), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7999) },
                    { new Guid("066548a7-01fd-4f7b-bdb7-aa4dd151ca3e"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7774), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7776) },
                    { new Guid("e4c20e9c-b4ed-49ce-a52e-fdd4df19c3b5"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7789), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7790) },
                    { new Guid("ff32b3af-86d3-469a-85ec-672c1c35d9f7"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7796), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7797) },
                    { new Guid("42e7caab-53e9-4bfd-833b-e7fb500496c8"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7803), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7803) },
                    { new Guid("7a7f7be3-4180-4135-8e47-59db5c732bab"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7809), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7810) },
                    { new Guid("4b2be462-483f-4461-9a86-da56cadde57c"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7815), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7816) },
                    { new Guid("6e973ad6-a141-4288-b021-298334a1c2cb"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7821), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7822) },
                    { new Guid("5049774f-6377-4f4b-9504-ce8e8de3232a"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7827), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7828) },
                    { new Guid("c104d562-dc9f-496d-b096-a367e7d6b3cc"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7833), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7834) },
                    { new Guid("8e054f5c-f4fa-4935-8dc8-5b1f99bfb595"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7839), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7840) },
                    { new Guid("1e169804-eee7-4c1d-96fb-e043de8e3f84"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8004), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(8005) },
                    { new Guid("0d7fedf7-6ed3-4e0b-a27d-0a6d44609c29"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7851), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7852) },
                    { new Guid("c50e74b6-0905-4714-95fd-f311f6980a1a"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7845), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7846) }
                });

            migrationBuilder.InsertData(
                table: "CastActors",
                columns: new[] { "Id", "ActorId", "CastId", "CreatedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { new Guid("ed24b6ab-1ff2-426c-8762-36a4997b4e5e"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7863), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7864) },
                    { new Guid("cf1f291a-ff8f-4adc-acf1-2b99d91f5eb2"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7993), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7994) },
                    { new Guid("a191f494-e46d-4f93-9837-f1e1bcacf9d5"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7988), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7988) },
                    { new Guid("764a6275-b62f-40bd-a198-fb20fd65eea6"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7858), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7858) },
                    { new Guid("415091cd-cf5e-4cb5-8910-c8fd5a16a04b"), new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"), new Guid("71033605-948c-4cdd-af69-9f026440105d"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7976), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7977) },
                    { new Guid("e0ba1d15-30c4-426a-9a21-8e1693a02a94"), new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"), new Guid("71033605-948c-4cdd-af69-9f026440105d"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7970), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7971) },
                    { new Guid("a70e1e7a-6c78-4254-aa9e-5c257780b0e5"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7981), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7982) },
                    { new Guid("9d4e86cd-2ce3-4c36-9ed5-b154e790d6b8"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7886), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7887) },
                    { new Guid("f64bd797-5acc-4c94-afcd-f2c16ede5f6c"), new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"), new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7881), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7882) },
                    { new Guid("7ff13950-4844-4b78-8c27-064b73f8011f"), new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"), new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7875), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7876) },
                    { new Guid("7196c793-950e-46a2-8332-a295017ce800"), new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"), new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7869), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7870) },
                    { new Guid("1d26f63a-bc61-4415-961a-66b9674d7d71"), new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"), new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7964), new DateTime(2021, 4, 18, 11, 58, 53, 690, DateTimeKind.Utc).AddTicks(7965) }
                });

            migrationBuilder.InsertData(
                table: "CastMovies",
                columns: new[] { "Id", "CastId", "CreatedAt", "ModifiedAt", "MovieId" },
                values: new object[,]
                {
                    { new Guid("a654414c-61fa-4f78-aab0-fbec2bc09943"), new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2064), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2064), new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4") },
                    { new Guid("f39501fe-1b4c-48c4-ba8a-097be505ddbc"), new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2093), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2093), new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e") },
                    { new Guid("2f1696b7-2106-4ba3-aab9-dcb4104b3164"), new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2081), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2082), new Guid("f98499a3-00a6-4335-a175-53a30b5b7246") },
                    { new Guid("73060af6-648b-4e45-ab1f-c5532ddf4aab"), new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2076), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2076), new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655") },
                    { new Guid("0690e320-10dd-4588-9d09-d6f6445ad7c9"), new Guid("71033605-948c-4cdd-af69-9f026440105d"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2070), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2071), new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a") },
                    { new Guid("870e522a-bef6-47fd-bf00-05ce6b7de7e4"), new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2057), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2058), new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c") },
                    { new Guid("61286443-8e8f-47ff-9b78-08004ea81505"), new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2087), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2088), new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682") },
                    { new Guid("49cf59b0-9233-40a4-b693-de1c38e2522c"), new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2045), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2046), new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba") },
                    { new Guid("f55f1898-3a6f-44ce-aee9-219dab718c3c"), new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(795), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(799), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698") },
                    { new Guid("200a9565-0135-41c9-9943-9c5adf40abf0"), new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2011), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2014), new Guid("db03a785-ffbb-4599-9add-763ae9156d83") },
                    { new Guid("c5f9b948-7a86-4a76-8237-a7eee1ed8da8"), new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2052), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2052), new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7") },
                    { new Guid("13cd344a-fc86-4974-9924-ab91fff0fd79"), new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2033), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2034), new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2") },
                    { new Guid("4db6c2ae-66ac-4700-aeae-38c179715b2d"), new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2039), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2040), new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8") },
                    { new Guid("b4462faf-1d7c-403a-9d93-c2bc6db50aad"), new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2027), new DateTime(2021, 4, 18, 11, 58, 53, 685, DateTimeKind.Utc).AddTicks(2028), new Guid("1f921843-87da-476b-8dfb-4ab892977ba1") }
                });

            migrationBuilder.InsertData(
                table: "CastTvShows",
                columns: new[] { "Id", "CastId", "CreatedAt", "ModifiedAt", "TvShowId" },
                values: new object[,]
                {
                    { new Guid("25b51889-0b8a-4d6f-94dd-acddf4c06947"), new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8248), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8248), new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce") },
                    { new Guid("1d4abba4-8497-4d6b-819f-f1415ffb8630"), new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8242), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8243), new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5") },
                    { new Guid("b12d35f3-2d06-40c1-a997-e7151ed6828e"), new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(7004), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(7008), new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909") },
                    { new Guid("ac813478-c61f-4d72-85d5-b76da3ee5395"), new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8231), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8232), new Guid("5e47a903-c741-4c69-a946-576a62178499") },
                    { new Guid("d308a3e5-ad0a-48f8-af80-7f9a17d7dd6a"), new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8226), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8227), new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c") },
                    { new Guid("7bb9fbd4-4ce9-4845-b507-5af6491a6333"), new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8220), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8221), new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f") },
                    { new Guid("307c2f2f-d876-4054-9f57-3876ffa7182b"), new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8214), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8215), new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce") },
                    { new Guid("d87c9786-472e-4eee-91cc-baf0a280c243"), new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8208), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8209), new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431") },
                    { new Guid("c2d48d6f-1130-4023-81a8-815401221ac7"), new Guid("45712daf-7f0e-47a4-8116-d84268109177"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8202), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8202), new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc") },
                    { new Guid("2eb40a1c-af4a-4b74-a3b1-b0e4d86535aa"), new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8187), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8190), new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8") },
                    { new Guid("a89b6cb7-75ea-4597-b3d1-7d88068e438a"), new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8236), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8237), new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d") },
                    { new Guid("bde5f711-6f87-41d4-b63e-ad235af84df8"), new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8254), new DateTime(2021, 4, 18, 11, 58, 53, 683, DateTimeKind.Utc).AddTicks(8254), new Guid("34a59d35-558c-4183-99b9-0457652f8663") }
                });

            migrationBuilder.InsertData(
                table: "RatingMovies",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { new Guid("b9d5795d-bac6-4587-8f79-c09060dca323"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(844), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(845), new Guid("db03a785-ffbb-4599-9add-763ae9156d83"), new Guid("92fde2b4-2f7e-4713-873e-3e19b3d00380") },
                    { new Guid("375dcc1f-4383-4277-8c27-07352427ae00"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1077), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1078), new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"), new Guid("5f7ef726-22d2-4f7e-80f4-1ab24c3c26a9") },
                    { new Guid("4d328fb5-ac19-4556-ad7b-fadfc66ceb12"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1085), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1086), new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"), new Guid("7235e79b-3794-4d03-a78c-cf724772778b") },
                    { new Guid("0d5a3139-8d2f-47de-afc2-7e10a0a6def4"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1094), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1095), new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655"), new Guid("704cd083-5dea-4599-a95a-618687fcd5fe") }
                });

            migrationBuilder.InsertData(
                table: "RatingMovies",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "MovieId", "RatingId" },
                values: new object[,]
                {
                    { new Guid("f556e910-a09e-47f5-9b56-f1fa54e8e93e"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1106), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1107), new Guid("f98499a3-00a6-4335-a175-53a30b5b7246"), new Guid("62480509-2c97-473f-bbe9-c097a4c46f5f") },
                    { new Guid("cd17ccc5-27da-4793-b442-01c952b653a9"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1117), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1119), new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682"), new Guid("6ca7dcad-8db9-4956-ba9b-7c53f00cd69a") },
                    { new Guid("00191eb0-4e0f-44cb-93e9-aa4c828e1be5"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(833), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(834), new Guid("db03a785-ffbb-4599-9add-763ae9156d83"), new Guid("33c0c66c-65db-4c6d-b65b-8453ca9c36a4") },
                    { new Guid("abae2cc6-0f61-4b7d-8d0b-733880c96f3d"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(811), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(813), new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"), new Guid("aa87369c-2cde-44e3-a6b2-0ee7863005c4") },
                    { new Guid("950eef59-2c6e-44a9-8169-c57faef8b6e7"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1065), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1067), new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"), new Guid("b6410b02-82b2-4244-8445-442de29908d3") },
                    { new Guid("c4528aa3-4d62-4726-b66e-14e914375350"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(800), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(802), new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"), new Guid("bdd9f99a-0ce7-48f2-ad91-dd7b2bf54a0a") },
                    { new Guid("ca3a93fe-2cb0-48cd-b7fd-9d3b0409e388"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(778), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(780), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("d635273d-e4ae-4c80-bf3f-423daf6ef44c") },
                    { new Guid("bb3c2dad-aed2-4366-88aa-4cf4a478a143"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(767), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(768), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("7009d22f-43bc-4b75-8063-99c6ef7f73c7") },
                    { new Guid("116861b8-d20e-4049-8991-8b67c3a0dbe7"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(753), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(754), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("9017f600-9bf3-48df-851c-a988fbf538ca") },
                    { new Guid("10aa6fd5-6392-49ed-9d6a-1bb73ac2eddc"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(742), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(744), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("fa7af4e4-aa07-47d0-9bdd-241d899f0d43") },
                    { new Guid("e670875d-a509-4044-9505-6ea9324ebaf4"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(731), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(733), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("6ac06f71-b7fb-4c1f-b6d6-014faf2be2b6") },
                    { new Guid("0409ecf4-eeae-4e95-8e95-b616b53a0906"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(710), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(714), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("c34e4947-510b-4083-ae7a-8040c623bc2e") },
                    { new Guid("a0912ca9-95c6-41a4-b0de-576140d28ebd"), new DateTime(2021, 4, 18, 11, 58, 53, 701, DateTimeKind.Utc).AddTicks(9050), new DateTime(2021, 4, 18, 11, 58, 53, 701, DateTimeKind.Utc).AddTicks(9057), new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"), new Guid("76a4eaa4-25a8-4469-93ea-08ccd05a60ae") },
                    { new Guid("a08e5f84-b0ba-4feb-9f9d-7168670681ad"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(789), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(791), new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"), new Guid("d9acba2e-cfd8-47ef-82b6-35f29bcf0f72") },
                    { new Guid("02c787d8-e17f-4b4f-a214-7f5a9f7c2c7e"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1055), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1056), new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"), new Guid("9baacbc3-8000-46e5-b57f-f664bb35e456") },
                    { new Guid("0064ca0c-72bd-4be7-8d29-3783af4a3ecb"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1128), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1129), new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e"), new Guid("53ee0e5a-70be-4c6f-8e65-b908ed399ee5") },
                    { new Guid("4353b901-7eab-4864-9224-55ebef00f177"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1034), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1035), new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"), new Guid("1109cbd5-93ef-4145-a29a-32ae758bf92c") },
                    { new Guid("787b642c-8e66-4515-875f-be27fbe4b24c"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(855), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(856), new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"), new Guid("dd4e4db2-4cfe-4174-b668-9255234867cb") },
                    { new Guid("3c9c01a9-dd1f-4a7a-9267-dda9c426030a"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(867), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(868), new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"), new Guid("ec0157b5-7919-4093-a2ff-5edfd5b2e579") },
                    { new Guid("bce41335-1088-4776-8f85-57d8a9f63654"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(877), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(878), new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"), new Guid("109ae507-d931-4fa5-b842-83bbf14af8e3") },
                    { new Guid("fd9f20d3-62c4-4edb-a5e2-e31326be8256"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(887), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(888), new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"), new Guid("510b4e8e-33eb-4103-a29a-d7cfe3bd1b84") },
                    { new Guid("ee4b1aa7-293d-40ba-b8a2-9981ec471849"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(897), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(898), new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"), new Guid("50fad2c1-ec6f-4a22-9cf7-ac22ed7b7ba8") },
                    { new Guid("32af4900-2024-433e-892f-2b201ead11e1"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(907), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(909), new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"), new Guid("b4319a50-d682-4944-af47-369c79a879bd") },
                    { new Guid("066e7046-c40b-48cd-93f0-beec15c4bfe5"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1044), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1046), new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"), new Guid("00363923-b800-4958-8e73-a3ae096453d9") },
                    { new Guid("90642267-2326-447f-9953-0a983625bae9"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(928), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(929), new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"), new Guid("92353641-44ee-4bd6-a75f-c3dc0d8ed456") },
                    { new Guid("289388b5-719f-4478-a588-1be283fadfac"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(938), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(939), new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"), new Guid("6e0fed50-8009-40cd-bbef-fa668abffd9e") },
                    { new Guid("3b9ba4b4-44b5-42c2-9ce4-7e085690fee5"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(917), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(918), new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"), new Guid("7d7cf2c1-6d67-4b3b-9db6-10ee12e2f85b") },
                    { new Guid("8252a69a-7f7e-4b1c-a29f-0973c5c20a72"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1002), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1003), new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"), new Guid("0cd3fefc-968d-4387-a657-5308ea1e78e4") },
                    { new Guid("f9fed750-e27e-4155-af9a-3bf5350263fc"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(822), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(823), new Guid("db03a785-ffbb-4599-9add-763ae9156d83"), new Guid("60d0ff04-a35e-4580-a1f8-981ef6b72675") },
                    { new Guid("b7533080-ff49-42b9-8f6b-4283f5861257"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(948), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(949), new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"), new Guid("5beaf703-85ff-4272-aeb9-6ec279cf5417") },
                    { new Guid("9135a509-1f27-4231-b5f5-48ccb761ed1d"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(958), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(959), new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"), new Guid("29b91bf0-cee2-46ad-9f05-ff01382faf84") },
                    { new Guid("4e490c3c-22e4-4364-9937-8ded3d0f825b"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(989), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(991), new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"), new Guid("3d455335-0b64-4220-8efb-5508fe1336fc") },
                    { new Guid("e1501aec-50d5-4ef2-8e2f-2175c44094aa"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(969), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(970), new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"), new Guid("b110b30c-67dc-43c4-81bf-1208a921f27f") },
                    { new Guid("80cc1da6-3684-4cce-aa49-6f10958746b2"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1013), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(1014), new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"), new Guid("cb7ae9bc-1abc-4712-9a8b-dc7ad52f311d") },
                    { new Guid("6f835675-59f8-4dc6-82f7-36d1847644b2"), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(979), new DateTime(2021, 4, 18, 11, 58, 53, 702, DateTimeKind.Utc).AddTicks(980), new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"), new Guid("d452ee9c-7f5e-46ac-9ff7-243997b3e463") }
                });

            migrationBuilder.InsertData(
                table: "RatingTvShows",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RatingId", "TvShowId" },
                values: new object[,]
                {
                    { new Guid("6d97eedc-ffa4-4237-82f4-4530b82edcd2"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2544), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2545), new Guid("9f296723-66a5-403c-9d98-e21650f88ce4"), new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce") },
                    { new Guid("34a59d35-558c-4183-99b9-0457652f8663"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2552), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2552), new Guid("abe5c938-b5cd-4dbd-9602-b7ce2c31d232"), new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce") },
                    { new Guid("8510011b-a914-43b5-9ff3-5add73a25950"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2535), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2535), new Guid("0b72821c-2c78-46de-8eae-7c2bf1573e4c"), new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5") },
                    { new Guid("b2c49663-7e9f-46e7-84ca-eba0327600b3"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2526), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2527), new Guid("46632975-c0d8-471b-ada2-7a5fe6c3b4af"), new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d") },
                    { new Guid("e63e31e8-0a4c-4ec6-bff2-25876a08e651"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2509), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2510), new Guid("d4f5c5cd-c093-44f5-8cb3-cad53c281aac"), new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f") },
                    { new Guid("fd526d17-6d21-47cc-9f62-ce20155a0f76"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2450), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2451), new Guid("853a954d-652b-4e12-9aff-88585f53fa32"), new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909") },
                    { new Guid("2dc06588-d846-41b6-9cf1-68b67f87ad8a"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2502), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2502), new Guid("52f05984-2671-4482-ab52-63585f5cc9dd"), new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce") }
                });

            migrationBuilder.InsertData(
                table: "RatingTvShows",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RatingId", "TvShowId" },
                values: new object[,]
                {
                    { new Guid("0c9b4700-9bac-4426-8b50-83cb952cb4d7"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2493), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2494), new Guid("03bed403-761f-4c26-85b7-0f45b9cfdd18"), new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431") },
                    { new Guid("5fa26558-ceda-4f77-a7cb-e8653b6e6d1c"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(1038), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(1044), new Guid("19d162da-67fa-4712-8d4f-3bffc4d83d47"), new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909") },
                    { new Guid("d404cea5-32e5-44c3-b1ff-f0eaeb717d0f"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2476), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2477), new Guid("d6892c99-c8eb-4fc9-845f-98340576d868"), new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8") },
                    { new Guid("e9c83243-b287-4d66-b217-22739a0be8b8"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2467), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2468), new Guid("bdfa3907-806f-4932-b974-63c9f56f76cf"), new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8") },
                    { new Guid("c3ea0cca-7204-4d24-a531-f2541f86b884"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2459), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2460), new Guid("8caf4fc5-f4af-4fa9-a00b-d6ae1b98833a"), new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8") },
                    { new Guid("8d144b29-550c-4896-b84a-2f5ad2d718f9"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2518), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2519), new Guid("2dc113d1-c9bc-48f9-b18e-b62381ff853a"), new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c") },
                    { new Guid("1b4b61c4-f3fe-43ba-b162-5d731b732ef9"), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2424), new DateTime(2021, 4, 18, 11, 58, 53, 704, DateTimeKind.Utc).AddTicks(2428), new Guid("510e4555-d700-4284-8a12-27569c80a98f"), new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastActors_ActorId",
                table: "CastActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_CastActors_CastId",
                table: "CastActors",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_CastMovies_CastId",
                table: "CastMovies",
                column: "CastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CastMovies_MovieId",
                table: "CastMovies",
                column: "MovieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CastTvShows_CastId",
                table: "CastTvShows",
                column: "CastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CastTvShows_TvShowId",
                table: "CastTvShows",
                column: "TvShowId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatingMovies_MovieId",
                table: "RatingMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingMovies_RatingId",
                table: "RatingMovies",
                column: "RatingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatingTvShows_RatingId",
                table: "RatingTvShows",
                column: "RatingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatingTvShows_TvShowId",
                table: "RatingTvShows",
                column: "TvShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastActors");

            migrationBuilder.DropTable(
                name: "CastMovies");

            migrationBuilder.DropTable(
                name: "CastTvShows");

            migrationBuilder.DropTable(
                name: "RatingMovies");

            migrationBuilder.DropTable(
                name: "RatingTvShows");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "TvShows");
        }
    }
}
