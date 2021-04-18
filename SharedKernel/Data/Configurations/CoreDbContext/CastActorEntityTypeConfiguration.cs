using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class CastActorEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<CastActor, Guid>
    {
        public override void Configure(EntityTypeBuilder<CastActor> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new CastActor
                {
                    Id = new Guid("d3940e55-c01f-4322-818b-85e8c1e69995"),
                    CastId = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("066548a7-01fd-4f7b-bdb7-aa4dd151ca3e"),
                    CastId = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("e4c20e9c-b4ed-49ce-a52e-fdd4df19c3b5"),
                    CastId = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("ff32b3af-86d3-469a-85ec-672c1c35d9f7"),
                    CastId = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("42e7caab-53e9-4bfd-833b-e7fb500496c8"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("7a7f7be3-4180-4135-8e47-59db5c732bab"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("4b2be462-483f-4461-9a86-da56cadde57c"),
                    CastId = new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("6e973ad6-a141-4288-b021-298334a1c2cb"),
                    CastId = new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("5049774f-6377-4f4b-9504-ce8e8de3232a"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("c104d562-dc9f-496d-b096-a367e7d6b3cc"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("8e054f5c-f4fa-4935-8dc8-5b1f99bfb595"),
                    CastId = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("c50e74b6-0905-4714-95fd-f311f6980a1a"),
                    CastId = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("0d7fedf7-6ed3-4e0b-a27d-0a6d44609c29"),
                    CastId = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("764a6275-b62f-40bd-a198-fb20fd65eea6"),
                    CastId = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("ed24b6ab-1ff2-426c-8762-36a4997b4e5e"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("7196c793-950e-46a2-8332-a295017ce800"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("7ff13950-4844-4b78-8c27-064b73f8011f"),
                    CastId = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("f64bd797-5acc-4c94-afcd-f2c16ede5f6c"),
                    CastId = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("9d4e86cd-2ce3-4c36-9ed5-b154e790d6b8"),
                    CastId = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("1d26f63a-bc61-4415-961a-66b9674d7d71"),
                    CastId = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("e0ba1d15-30c4-426a-9a21-8e1693a02a94"),
                    CastId = new Guid("71033605-948c-4cdd-af69-9f026440105d"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("415091cd-cf5e-4cb5-8910-c8fd5a16a04b"),
                    CastId = new Guid("71033605-948c-4cdd-af69-9f026440105d"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("a70e1e7a-6c78-4254-aa9e-5c257780b0e5"),
                    CastId = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("a191f494-e46d-4f93-9837-f1e1bcacf9d5"),
                    CastId = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("cf1f291a-ff8f-4adc-acf1-2b99d91f5eb2"),
                    CastId = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("a642784a-f507-4605-a924-4406cc8acc78"),
                    CastId = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("1e169804-eee7-4c1d-96fb-e043de8e3f84"),
                    CastId = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("76f4d432-738c-42cc-a9ac-8b38dc8ed585"),
                    CastId = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("a4b9c47a-b530-4f6f-84af-7e7981085618"),
                    CastId = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("46cbb4f1-c660-4626-bfca-452ae3cbfe65"),
                    CastId = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("3a4bd340-1112-4af8-80fc-10490a082a1b"),
                    CastId = new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("b13d156e-c3c7-4c30-bf7a-b3a886786563"),
                    CastId = new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("198e0698-5965-4ee6-8a5a-8dffca9f514a"),
                    CastId = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("77b6d180-8e8d-4f50-846d-174415ce2eee"),
                    CastId = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("c40ccfef-9b7e-4d79-859f-bc61c1e30e0f"),
                    CastId = new Guid("45712daf-7f0e-47a4-8116-d84268109177"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("ddd42203-0439-49fb-8ffa-e527c0478e41"),
                    CastId = new Guid("45712daf-7f0e-47a4-8116-d84268109177"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("a2a1e81f-c63d-4e74-bbe1-1557533bea84"),
                    CastId = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("c519a4b9-0d5f-4564-9e76-10cb7c583f59"),
                    CastId = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("7ba4a07e-abc0-4e3d-8cf6-7f3a6564c657"),
                    CastId = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("4d58170f-bb87-452e-bcaa-916fa10270e2"),
                    CastId = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("1bfb8dd8-f700-4c69-8e4f-fc1dc8d76ca2"),
                    CastId = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("35a861fc-5328-4178-9299-3d19407ba451"),
                    CastId = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("432bf952-a3f3-4174-96e1-4994969f219b"),
                    CastId = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("c949749a-a7f1-4fa0-a616-330d9a4362d6"),
                    CastId = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("611ca1d4-9457-4a1e-825e-414263e63cab"),
                    CastId = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("b40311b4-cee0-4df1-a8f4-bc6104369e52"),
                    CastId = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("df600a1d-a9c4-4255-8076-ab9e225573e9"),
                    CastId = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("d76f0119-dd08-437a-b018-f3ec8c2a52cc"),
                    CastId = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("ed547ac9-9cbb-4376-9706-7c168da0f224"),
                    CastId = new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("f99f2662-3603-4c4b-b32f-0a216aeab9ad"),
                    CastId = new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a"),
                    ActorId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new CastActor
                {
                    Id = new Guid("cec6e9e5-94bb-49d5-bc85-ae050cfd8f2d"),
                    CastId = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("1d6a882f-7d0a-4b93-ad87-d89807320db5"),
                    CastId = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("506062ab-4155-42f2-a7a9-8e28c79a9513"),
                    CastId = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"),
                    ActorId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new CastActor
                {
                    Id = new Guid("08ab9542-30cd-4b17-8084-5a2e23ac3ca9"),
                    CastId = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                }
            );
        }
    }
}