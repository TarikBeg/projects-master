using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class CastMovieEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<CastMovie, Guid>
    {
        public override void Configure(EntityTypeBuilder<CastMovie> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new CastMovie
                {
                    Id = new Guid("f55f1898-3a6f-44ce-aee9-219dab718c3c"),
                    CastId = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698")
                },
                new CastMovie
                {
                    Id = new Guid("200a9565-0135-41c9-9943-9c5adf40abf0"),
                    CastId = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"),
                    MovieId = new Guid("db03a785-ffbb-4599-9add-763ae9156d83")
                },
                new CastMovie
                {
                    Id = new Guid("b4462faf-1d7c-403a-9d93-c2bc6db50aad"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    MovieId = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1")
                },
                new CastMovie
                {
                    Id = new Guid("13cd344a-fc86-4974-9924-ab91fff0fd79"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    MovieId = new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2")
                },
                new CastMovie
                {
                    Id = new Guid("4db6c2ae-66ac-4700-aeae-38c179715b2d"),
                    CastId = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"),
                    MovieId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8")
                },
                new CastMovie
                {
                    Id = new Guid("49cf59b0-9233-40a4-b693-de1c38e2522c"),
                    CastId = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"),
                    MovieId = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba")
                },
                new CastMovie
                {
                    Id = new Guid("c5f9b948-7a86-4a76-8237-a7eee1ed8da8"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    MovieId = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7")
                },
                new CastMovie
                {
                    Id = new Guid("870e522a-bef6-47fd-bf00-05ce6b7de7e4"),
                    CastId = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"),
                    MovieId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c")
                },
                new CastMovie
                {
                    Id = new Guid("a654414c-61fa-4f78-aab0-fbec2bc09943"),
                    CastId = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"),
                    MovieId = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4")
                },
                new CastMovie
                {
                    Id = new Guid("0690e320-10dd-4588-9d09-d6f6445ad7c9"),
                    CastId = new Guid("71033605-948c-4cdd-af69-9f026440105d"),
                    MovieId = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a")
                },
                new CastMovie
                {
                    Id = new Guid("73060af6-648b-4e45-ab1f-c5532ddf4aab"),
                    CastId = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"),
                    MovieId = new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655")
                },
                new CastMovie
                {
                    Id = new Guid("2f1696b7-2106-4ba3-aab9-dcb4104b3164"),
                    CastId = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"),
                    MovieId = new Guid("f98499a3-00a6-4335-a175-53a30b5b7246")
                },
                new CastMovie
                {
                    Id = new Guid("61286443-8e8f-47ff-9b78-08004ea81505"),
                    CastId = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"),
                    MovieId = new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682")
                },
                new CastMovie
                {
                    Id = new Guid("f39501fe-1b4c-48c4-ba8a-097be505ddbc"),
                    CastId = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"),
                    MovieId = new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e")
                }
            );
        }
    }
}