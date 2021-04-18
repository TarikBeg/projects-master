using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class RatingTvShowEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<RatingTvShow, Guid>
    {
        public override void Configure(EntityTypeBuilder<RatingTvShow> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.TvShowId).IsRequired();
            builder.Property(x => x.RatingId).ValueGeneratedOnAdd();

            builder.HasData(
                new RatingTvShow
                {
                    Id = new Guid("5fa26558-ceda-4f77-a7cb-e8653b6e6d1c"),
                    TvShowId = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"),
                    RatingId = new Guid("19d162da-67fa-4712-8d4f-3bffc4d83d47")
                },
                new RatingTvShow
                {
                    Id = new Guid("1b4b61c4-f3fe-43ba-b162-5d731b732ef9"),
                    TvShowId = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"),
                    RatingId = new Guid("510e4555-d700-4284-8a12-27569c80a98f")
                },
                new RatingTvShow
                {
                    Id = new Guid("fd526d17-6d21-47cc-9f62-ce20155a0f76"),
                    TvShowId = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"),
                    RatingId = new Guid("853a954d-652b-4e12-9aff-88585f53fa32")
                },
                new RatingTvShow
                {
                    Id = new Guid("c3ea0cca-7204-4d24-a531-f2541f86b884"),
                    TvShowId = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"),
                    RatingId = new Guid("8caf4fc5-f4af-4fa9-a00b-d6ae1b98833a")
                },
                new RatingTvShow
                {
                    Id = new Guid("e9c83243-b287-4d66-b217-22739a0be8b8"),
                    TvShowId = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"),
                    RatingId = new Guid("bdfa3907-806f-4932-b974-63c9f56f76cf")
                },
                new RatingTvShow
                {
                    Id = new Guid("d404cea5-32e5-44c3-b1ff-f0eaeb717d0f"),
                    TvShowId = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"),
                    RatingId = new Guid("d6892c99-c8eb-4fc9-845f-98340576d868")
                },
                new RatingTvShow
                {
                    Id = new Guid("27fede7e-2d8b-4594-ab06-00987135e6c0"),
                    TvShowId = new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc"),
                    RatingId = new Guid("03bed403-761f-4c26-85b7-0f45b9cfdd18")
                },
                new RatingTvShow
                {
                    Id = new Guid("0c9b4700-9bac-4426-8b50-83cb952cb4d7"),
                    TvShowId = new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431"),
                    RatingId = new Guid("03bed403-761f-4c26-85b7-0f45b9cfdd18")
                },
                new RatingTvShow
                {
                    Id = new Guid("2dc06588-d846-41b6-9cf1-68b67f87ad8a"),
                    TvShowId = new Guid("25a9b425-2dae-426b-8ce4-f57e3c9edfce"),
                    RatingId = new Guid("52f05984-2671-4482-ab52-63585f5cc9dd")
                },
                new RatingTvShow
                {
                    Id = new Guid("e63e31e8-0a4c-4ec6-bff2-25876a08e651"),
                    TvShowId = new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f"),
                    RatingId = new Guid("d4f5c5cd-c093-44f5-8cb3-cad53c281aac")
                },
                new RatingTvShow
                {
                    Id = new Guid("8d144b29-550c-4896-b84a-2f5ad2d718f9"),
                    TvShowId = new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c"),
                    RatingId = new Guid("2dc113d1-c9bc-48f9-b18e-b62381ff853a")
                },
                new RatingTvShow
                {
                    Id = new Guid("b2c49663-7e9f-46e7-84ca-eba0327600b3"),
                    TvShowId = new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d"),
                    RatingId = new Guid("46632975-c0d8-471b-ada2-7a5fe6c3b4af")
                },
                new RatingTvShow
                {
                    Id = new Guid("8510011b-a914-43b5-9ff3-5add73a25950"),
                    TvShowId = new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5"),
                    RatingId = new Guid("0b72821c-2c78-46de-8eae-7c2bf1573e4c")
                },
                new RatingTvShow
                {
                    Id = new Guid("6d97eedc-ffa4-4237-82f4-4530b82edcd2"),
                    TvShowId = new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce"),
                    RatingId = new Guid("9f296723-66a5-403c-9d98-e21650f88ce4")
                },
                new RatingTvShow
                {
                    Id = new Guid("34a59d35-558c-4183-99b9-0457652f8663"),
                    TvShowId = new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce"),
                    RatingId = new Guid("abe5c938-b5cd-4dbd-9602-b7ce2c31d232")
                }
            );
        }
    }
}