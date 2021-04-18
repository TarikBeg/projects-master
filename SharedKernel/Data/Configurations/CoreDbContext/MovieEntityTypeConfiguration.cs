using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class MovieEntityTypeConfiguration : AggregateRootTypeConfigurationNoVersioning<Movie, Guid>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(p => p.Ratings)
                .WithOne(p => p.Movie)
                .HasForeignKey(x => x.MovieId);

            builder
                .HasOne(p => p.CastMovie)
                .WithOne(p => p.Movie);

            builder.HasData(
                new Movie
                {
                    Id = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    Title = " The Shawshank Redemption",
                    ReleaseDate = new DateTime(1994, 9, 14),
                    Description =
                        "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheShawshankRedemption.jpg",
                    AverageRating = 10
                },
                new Movie
                {
                    Id = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                    Title = "The Godfather",
                    ReleaseDate = new DateTime(1972, 2, 4),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheGodfather.jpg",
                    Description =
                        "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    AverageRating = 10
                },
                new Movie
                {
                    Id = new Guid("db03a785-ffbb-4599-9add-763ae9156d83"),
                    Title = "The Godfather: Part II",
                    ReleaseDate = new DateTime(1972, 2, 4),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheGodfatherPartII.jpg",
                    Description =
                        "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    AverageRating = 9
                },
                new Movie
                {
                    Id = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"),
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 10, 21),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheDarkKnight.jpg",
                    Description =
                        "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    AverageRating = 8
                },
                new Movie
                {
                    Id = new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2"),
                    Title = "12 Angry Men",
                    ReleaseDate = new DateTime(1957, 3, 31),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/12AngryMen.jpg",
                    Description =
                        "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    AverageRating = 8
                },
                new Movie
                {
                    Id = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    Title = "Schindler's List",
                    ReleaseDate = new DateTime(1993, 12, 1),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/SchindlerList.jpg",
                    Description =
                        "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    AverageRating = 7
                },
                new Movie
                {
                    Id = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"),
                    Title = "Pulp Fiction",
                    ReleaseDate = new DateTime(1994, 12, 1),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/PulpFiction.jpg",
                    Description =
                        "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    AverageRating = 7
                },
                new Movie
                {
                    Id = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"),
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = new DateTime(2003, 2, 17),
                    CoverImage =
                        "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheReturnoftheKing.jpg",
                    Description =
                        "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
                },
                new Movie
                {
                    Id = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    Title = "The Good, the Bad and the Ugly",
                    ReleaseDate = new DateTime(1966, 4, 22),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheGoodtheBadandtheUgly.jpg",
                    Description =
                        "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    AverageRating = 4
                },
                new Movie
                {
                    Id = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"),
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = new DateTime(2001, 4, 19),
                    CoverImage =
                        "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheFellowshipoftheRing.jpg",
                    Description =
                        "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    AverageRating = 4.6
                },
                new Movie
                {
                    Id = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"),
                    Title = "Fight Club",
                    ReleaseDate = new DateTime(1999, 1, 22),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/FightClub.jpg",
                    Description =
                        "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    AverageRating = 3.2
                },
                new Movie
                {
                    Id = new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655"),
                    Title = "Forrest Gump",
                    ReleaseDate = new DateTime(1994, 5, 26),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/ForrestGump.jpg",
                    Description =
                        "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    AverageRating =3
                },
                new Movie
                {
                    Id = new Guid("f98499a3-00a6-4335-a175-53a30b5b7246"),
                    Title = "Inception",
                    ReleaseDate = new DateTime(2010, 7, 27),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/Inception.jpg",
                    Description =
                        "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    AverageRating = 3
                },
                new Movie
                {
                    Id = new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682"),
                    Title = "The Lord of the Rings: The Two Towers",
                    ReleaseDate = new DateTime(2002, 7, 27),
                    CoverImage =
                        "https://mistraltask.blob.core.windows.net/mistraltask/TheLordoftheRingsTheTwoTowers.jpg",
                    Description =
                        "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                    AverageRating = 2
                },
                new Movie
                {
                    Id = new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e"),
                    Title = "Star Wars: Episode V - The Empire Strikes Back",
                    ReleaseDate = new DateTime(1980, 7, 27),
                    CoverImage =
                        "https://mistraltask.blob.core.windows.net/mistraltask/StarWarsEpisodeVTheEmpireStrikesBack.jpg",
                    Description =
                        "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader and a bounty hunter named Boba Fett all over the galaxy.",
                    AverageRating = 1
                }
            );
        }
    }
}