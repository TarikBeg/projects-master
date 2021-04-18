using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class CastTvShowEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<CastTvShow, Guid>
    {
        public override void Configure(EntityTypeBuilder<CastTvShow> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new CastTvShow
                {
                    Id = new Guid("b12d35f3-2d06-40c1-a997-e7151ed6828e"),
                    CastId = new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"),
                    TvShowId = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909")
                },
                new CastTvShow
                {
                    Id = new Guid("2eb40a1c-af4a-4b74-a3b1-b0e4d86535aa"),
                    CastId = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"),
                    TvShowId = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8")
                },
                new CastTvShow
                {
                    Id = new Guid("c2d48d6f-1130-4023-81a8-815401221ac7"),
                    CastId = new Guid("45712daf-7f0e-47a4-8116-d84268109177"),
                    TvShowId = new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc")
                },
                new CastTvShow
                {
                    Id = new Guid("d87c9786-472e-4eee-91cc-baf0a280c243"),
                    CastId = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"),
                    TvShowId = new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431")
                },
                new CastTvShow
                {
                    Id = new Guid("307c2f2f-d876-4054-9f57-3876ffa7182b"),
                    CastId = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"),
                    TvShowId = new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce")
                },
                new CastTvShow
                {
                    Id = new Guid("7bb9fbd4-4ce9-4845-b507-5af6491a6333"),
                    CastId = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"),
                    TvShowId = new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f")
                },
                new CastTvShow
                {
                    Id = new Guid("d308a3e5-ad0a-48f8-af80-7f9a17d7dd6a"),
                    CastId = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"),
                    TvShowId = new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c")
                },
                new CastTvShow
                {
                    Id = new Guid("ac813478-c61f-4d72-85d5-b76da3ee5395"),
                    CastId = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"),
                    TvShowId = new Guid("5e47a903-c741-4c69-a946-576a62178499")
                },
                new CastTvShow
                {
                    Id = new Guid("a89b6cb7-75ea-4597-b3d1-7d88068e438a"),
                    CastId = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"),
                    TvShowId = new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d")
                },
                new CastTvShow
                {
                    Id = new Guid("1d4abba4-8497-4d6b-819f-f1415ffb8630"),
                    CastId = new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"),
                    TvShowId = new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5")
                },
                new CastTvShow
                {
                    Id = new Guid("25b51889-0b8a-4d6f-94dd-acddf4c06947"),
                    CastId = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"),
                    TvShowId = new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce")
                },
                new CastTvShow
                {
                    Id = new Guid("bde5f711-6f87-41d4-b63e-ad235af84df8"),
                    CastId = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"),
                    TvShowId = new Guid("34a59d35-558c-4183-99b9-0457652f8663")
                }
            );
        }
    }
}