using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class RatingMovieEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<RatingMovie, Guid>
    {
        public override void Configure(EntityTypeBuilder<RatingMovie> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Movie)
                .WithMany(x => x.Ratings);

            builder.HasData(
                new RatingMovie
                {
                    Id = new Guid("a0912ca9-95c6-41a4-b0de-576140d28ebd"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("76a4eaa4-25a8-4469-93ea-08ccd05a60ae")
                },
                new RatingMovie
                {
                    Id = new Guid("0409ecf4-eeae-4e95-8e95-b616b53a0906"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("c34e4947-510b-4083-ae7a-8040c623bc2e")
                },
                new RatingMovie
                {
                    Id = new Guid("e670875d-a509-4044-9505-6ea9324ebaf4"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("6ac06f71-b7fb-4c1f-b6d6-014faf2be2b6")
                },
                new RatingMovie
                {
                    Id = new Guid("10aa6fd5-6392-49ed-9d6a-1bb73ac2eddc"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("fa7af4e4-aa07-47d0-9bdd-241d899f0d43")
                },
                new RatingMovie
                {
                    Id = new Guid("116861b8-d20e-4049-8991-8b67c3a0dbe7"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("9017f600-9bf3-48df-851c-a988fbf538ca")
                },
                new RatingMovie
                {
                    Id = new Guid("bb3c2dad-aed2-4366-88aa-4cf4a478a143"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("7009d22f-43bc-4b75-8063-99c6ef7f73c7")
                },
                new RatingMovie
                {
                    Id = new Guid("ca3a93fe-2cb0-48cd-b7fd-9d3b0409e388"),
                    MovieId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    RatingId = new Guid("d635273d-e4ae-4c80-bf3f-423daf6ef44c")
                },
                new RatingMovie
                {
                    Id = new Guid("a08e5f84-b0ba-4feb-9f9d-7168670681ad"),
                    MovieId = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                    RatingId = new Guid("d9acba2e-cfd8-47ef-82b6-35f29bcf0f72")
                },
                new RatingMovie
                {
                    Id = new Guid("c4528aa3-4d62-4726-b66e-14e914375350"),
                    MovieId = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                    RatingId = new Guid("bdd9f99a-0ce7-48f2-ad91-dd7b2bf54a0a")
                },
                new RatingMovie
                {
                    Id = new Guid("abae2cc6-0f61-4b7d-8d0b-733880c96f3d"),
                    MovieId = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                    RatingId = new Guid("aa87369c-2cde-44e3-a6b2-0ee7863005c4")
                },
                new RatingMovie
                {
                    Id = new Guid("f9fed750-e27e-4155-af9a-3bf5350263fc"),
                    MovieId = new Guid("db03a785-ffbb-4599-9add-763ae9156d83"),
                    RatingId = new Guid("60d0ff04-a35e-4580-a1f8-981ef6b72675")
                },
                new RatingMovie
                {
                    Id = new Guid("00191eb0-4e0f-44cb-93e9-aa4c828e1be5"),
                    MovieId = new Guid("db03a785-ffbb-4599-9add-763ae9156d83"),
                    RatingId = new Guid("33c0c66c-65db-4c6d-b65b-8453ca9c36a4")
                },
                new RatingMovie
                {
                    Id = new Guid("b9d5795d-bac6-4587-8f79-c09060dca323"),
                    MovieId = new Guid("db03a785-ffbb-4599-9add-763ae9156d83"),
                    RatingId = new Guid("92fde2b4-2f7e-4713-873e-3e19b3d00380")
                },
                new RatingMovie
                {
                    Id = new Guid("787b642c-8e66-4515-875f-be27fbe4b24c"),
                    MovieId = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"),
                    RatingId = new Guid("dd4e4db2-4cfe-4174-b668-9255234867cb")
                },
                new RatingMovie
                {
                    Id = new Guid("3c9c01a9-dd1f-4a7a-9267-dda9c426030a"),
                    MovieId = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"),
                    RatingId = new Guid("ec0157b5-7919-4093-a2ff-5edfd5b2e579")
                },
                new RatingMovie
                {
                    Id = new Guid("bce41335-1088-4776-8f85-57d8a9f63654"),
                    MovieId = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"),
                    RatingId = new Guid("109ae507-d931-4fa5-b842-83bbf14af8e3")
                },
                new RatingMovie
                {
                    Id = new Guid("fd9f20d3-62c4-4edb-a5e2-e31326be8256"),
                    MovieId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    RatingId = new Guid("510b4e8e-33eb-4103-a29a-d7cfe3bd1b84")
                },
                new RatingMovie
                {
                    Id = new Guid("ee4b1aa7-293d-40ba-b8a2-9981ec471849"),
                    MovieId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    RatingId = new Guid("50fad2c1-ec6f-4a22-9cf7-ac22ed7b7ba8")
                },
                new RatingMovie
                {
                    Id = new Guid("32af4900-2024-433e-892f-2b201ead11e1"),
                    MovieId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    RatingId = new Guid("b4319a50-d682-4944-af47-369c79a879bd")
                },
                new RatingMovie
                {
                    Id = new Guid("3b9ba4b4-44b5-42c2-9ce4-7e085690fee5"),
                    MovieId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    RatingId = new Guid("7d7cf2c1-6d67-4b3b-9db6-10ee12e2f85b")
                },
                new RatingMovie
                {
                    Id = new Guid("90642267-2326-447f-9953-0a983625bae9"),
                    MovieId = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"),
                    RatingId = new Guid("92353641-44ee-4bd6-a75f-c3dc0d8ed456")
                },
                new RatingMovie
                {
                    Id = new Guid("289388b5-719f-4478-a588-1be283fadfac"),
                    MovieId = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"),
                    RatingId = new Guid("6e0fed50-8009-40cd-bbef-fa668abffd9e")
                },
                new RatingMovie
                {
                    Id = new Guid("b7533080-ff49-42b9-8f6b-4283f5861257"),
                    MovieId = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"),
                    RatingId = new Guid("5beaf703-85ff-4272-aeb9-6ec279cf5417")
                },
                new RatingMovie
                {
                    Id = new Guid("9135a509-1f27-4231-b5f5-48ccb761ed1d"),
                    MovieId = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"),
                    RatingId = new Guid("29b91bf0-cee2-46ad-9f05-ff01382faf84")
                },
                new RatingMovie
                {
                    Id = new Guid("e1501aec-50d5-4ef2-8e2f-2175c44094aa"),
                    MovieId = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"),
                    RatingId = new Guid("b110b30c-67dc-43c4-81bf-1208a921f27f")
                },
                new RatingMovie
                {
                    Id = new Guid("6f835675-59f8-4dc6-82f7-36d1847644b2"),
                    MovieId = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"),
                    RatingId = new Guid("d452ee9c-7f5e-46ac-9ff7-243997b3e463")
                },
                new RatingMovie
                {
                    Id = new Guid("4e490c3c-22e4-4364-9937-8ded3d0f825b"),
                    MovieId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    RatingId = new Guid("3d455335-0b64-4220-8efb-5508fe1336fc")
                },
                new RatingMovie
                {
                    Id = new Guid("8252a69a-7f7e-4b1c-a29f-0973c5c20a72"),
                    MovieId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    RatingId = new Guid("0cd3fefc-968d-4387-a657-5308ea1e78e4")
                },
                new RatingMovie
                {
                    Id = new Guid("80cc1da6-3684-4cce-aa49-6f10958746b2"),
                    MovieId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    RatingId = new Guid("cb7ae9bc-1abc-4712-9a8b-dc7ad52f311d")
                },
                new RatingMovie
                {
                    Id = new Guid("d4392b4c-7ca1-42ca-bb71-c412e3d6fa29"),
                    MovieId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    RatingId = new Guid("1109cbd5-93ef-4145-a29a-32ae758bf92c")
                },
                new RatingMovie
                {
                    Id = new Guid("4353b901-7eab-4864-9224-55ebef00f177"),
                    MovieId = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"),
                    RatingId = new Guid("1109cbd5-93ef-4145-a29a-32ae758bf92c")
                },
                new RatingMovie
                {
                    Id = new Guid("066e7046-c40b-48cd-93f0-beec15c4bfe5"),
                    MovieId = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"),
                    RatingId = new Guid("00363923-b800-4958-8e73-a3ae096453d9")
                },
                new RatingMovie
                {
                    Id = new Guid("02c787d8-e17f-4b4f-a214-7f5a9f7c2c7e"),
                    MovieId = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"),
                    RatingId = new Guid("9baacbc3-8000-46e5-b57f-f664bb35e456")
                },
                new RatingMovie
                {
                    Id = new Guid("950eef59-2c6e-44a9-8169-c57faef8b6e7"),
                    MovieId = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"),
                    RatingId = new Guid("b6410b02-82b2-4244-8445-442de29908d3")
                },
                new RatingMovie
                {
                    Id = new Guid("375dcc1f-4383-4277-8c27-07352427ae00"),
                    MovieId = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"),
                    RatingId = new Guid("5f7ef726-22d2-4f7e-80f4-1ab24c3c26a9")
                },
                new RatingMovie
                {
                    Id = new Guid("4d328fb5-ac19-4556-ad7b-fadfc66ceb12"),
                    MovieId = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"),
                    RatingId = new Guid("7235e79b-3794-4d03-a78c-cf724772778b")
                },
                new RatingMovie
                {
                    Id = new Guid("0d5a3139-8d2f-47de-afc2-7e10a0a6def4"),
                    MovieId = new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655"),
                    RatingId = new Guid("704cd083-5dea-4599-a95a-618687fcd5fe")
                },
                new RatingMovie
                {
                    Id = new Guid("f556e910-a09e-47f5-9b56-f1fa54e8e93e"),
                    MovieId = new Guid("f98499a3-00a6-4335-a175-53a30b5b7246"),
                    RatingId = new Guid("62480509-2c97-473f-bbe9-c097a4c46f5f")
                },
                new RatingMovie
                {
                    Id = new Guid("cd17ccc5-27da-4793-b442-01c952b653a9"),
                    MovieId = new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682"),
                    RatingId = new Guid("6ca7dcad-8db9-4956-ba9b-7c53f00cd69a")
                },
                new RatingMovie
                {
                    Id = new Guid("0064ca0c-72bd-4be7-8d29-3783af4a3ecb"),
                    MovieId = new Guid("8a30ed42-ee09-4103-8f05-9c607503c04e"),
                    RatingId = new Guid("53ee0e5a-70be-4c6f-8e65-b908ed399ee5")
                }
            );
        }
    }
}