using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class CastEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<Cast, Guid>
    {
        public override void Configure(EntityTypeBuilder<Cast> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(p => p.CastActors)
                .WithOne(p => p.Cast);

            builder.HasData(
                new Cast
                {
                    Id = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b")
                },
                new Cast
                {
                    Id = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5")
                },
                new Cast
                {
                    Id = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56")
                },
                new Cast
                {
                    Id = new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4")
                },
                new Cast
                {
                    Id = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd")
                },
                new Cast
                {
                    Id = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce")
                },
                new Cast
                {
                    Id = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794")
                },
                new Cast
                {
                    Id = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9")
                },
                new Cast
                {
                    Id = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155")
                },
                new Cast
                {
                    Id = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e")
                },
                new Cast
                {
                    Id = new Guid("71033605-948c-4cdd-af69-9f026440105d")
                },
                new Cast
                {
                    Id = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770")
                },
                new Cast
                {
                    Id = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581")
                },
                new Cast
                {
                    Id = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad")
                },
                new Cast
                {
                    Id = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571")
                },
                new Cast
                {
                    Id = new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd")
                },
                new Cast
                {
                    Id = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c")
                },
                new Cast
                {
                    Id = new Guid("45712daf-7f0e-47a4-8116-d84268109177")
                },
                new Cast
                {
                    Id = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456")
                },
                new Cast
                {
                    Id = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf")
                },
                new Cast
                {
                    Id = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95")
                },
                new Cast
                {
                    Id = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06")
                },
                new Cast
                {
                    Id = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2")
                },
                new Cast
                {
                    Id = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7")
                },
                new Cast
                {
                    Id = new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a")
                },
                new Cast
                {
                    Id = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899")
                },
                new Cast
                {
                    Id = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a")
                }
            );
        }
    }
}