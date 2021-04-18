using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class TvShowEntityTypeConfiguration : AggregateRootTypeConfigurationNoVersioning<TvShow, Guid>
    {
        public override void Configure(EntityTypeBuilder<TvShow> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ReleaseDate).IsRequired();

            builder
                .HasMany(p => p.Ratings)
                .WithOne(p => p.TvShow)
                .HasForeignKey(x => x.TvShowId);

            builder
                .HasOne(p => p.CastTvShow)
                .WithOne(p => p.TvShow);

            builder.HasData(
                new TvShow
                {
                    Id = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"),
                    Title = "Planet Earth II",
                    Description =
                        "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals.",
                    ReleaseDate = new DateTime(2016, 3, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/PlanetEarthII.jpg",
                    AverageRating = 10
                },
                new TvShow
                {
                    Id = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"),
                    Title = "Planet Earth",
                    Description =
                        "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                    ReleaseDate = new DateTime(2006, 1, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/PlanetEarth.jpg",
                    AverageRating = 10
                },
                new TvShow
                {
                    Id = new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc"),
                    Title = "Band of Brothers",
                    Description =
                        "The story of Easy Company of the U.S. Army 101st Airborne Division, and their mission in World War II Europe, from Operation Overlord, through V-J Day.",
                    ReleaseDate = new DateTime(2001, 4, 29),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/BandofBrothers.jpg",
                    AverageRating = 9
                },
                new TvShow
                {
                    Id = new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431"),
                    Title = "Breaking Bad",
                    Description =
                        "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    ReleaseDate = new DateTime(2008, 6, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/BreakingBad.jpg",
                    AverageRating = 9
                },
                new TvShow
                {
                    Id = new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce"),
                    Title = " Chernobyl",
                    Description =
                        "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                    ReleaseDate = new DateTime(2019, 3, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/Chernobyl.jpg",
                    AverageRating = 8
                },
                new TvShow
                {
                    Id = new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f"),
                    Title = "Blue Planet II",
                    Description =
                        "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                    ReleaseDate = new DateTime(2017, 3, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/BluePlanetII.jpg",
                    AverageRating = 7
                },
                new TvShow
                {
                    Id = new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c"),
                    Title = "The Wire",
                    Description =
                        "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                    ReleaseDate = new DateTime(2002, 8, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/TheWire.jpg",
                    AverageRating = 6
                },
                new TvShow
                {
                    Id = new Guid("5e47a903-c741-4c69-a946-576a62178499"),
                    Title = "Our Planet",
                    Description =
                        "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                    ReleaseDate = new DateTime(2019, 8, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/OurPlanet.jpg",
                    AverageRating = 5
                },
                new TvShow
                {
                    Id = new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d"),
                    Title = "Cosmos",
                    Description =
                        "An exploration of our discovery of the laws of nature and coordinates in space and time.",
                    ReleaseDate = new DateTime(2014, 6, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/Cosmos.jpg",
                    AverageRating = 4
                },
                new TvShow
                {
                    Id = new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5"),
                    Title = "Cosmos",
                    Description =
                        "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                    ReleaseDate = new DateTime(1980, 8, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/Cosmos1980.jpg",
                    AverageRating = 4
                },
                new TvShow
                {
                    Id = new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce"),
                    Title = "Avatar: The Last Airbender",
                    Description =
                        "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    ReleaseDate = new DateTime(2005, 12, 12),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/AvatarTheLastAirbender.jpg",
                    AverageRating = 4
                },
                new TvShow
                {
                    Id = new Guid("34a59d35-558c-4183-99b9-0457652f8663"),
                    Title = "Game of Thrones",
                    Description =
                        "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    ReleaseDate = new DateTime(2011, 4, 3),
                    CoverImage = "https://mistraltask.blob.core.windows.net/mistraltask/GameofThrones.jpg",
                    AverageRating = 3
                }
            );
        }
    }
}