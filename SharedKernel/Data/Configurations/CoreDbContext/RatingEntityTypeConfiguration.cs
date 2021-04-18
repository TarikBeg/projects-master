using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class RatingEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<Rating, Guid>
    {
        public override void Configure(EntityTypeBuilder<Rating> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Star).IsRequired();

            builder.HasOne(b => b.RatingMovie)
                .WithOne(i => i.Rating)
                .HasForeignKey<RatingMovie>(b => b.RatingId);

            builder.HasOne(b => b.RatingTvShow)
                .WithOne(i => i.Rating)
                .HasForeignKey<RatingTvShow>(b => b.RatingId);

            builder.Property(p => p.Star)
                .IsRequired()
                .HasConversion(new ValueConverter<Star, int>(
                    v => v.Count,
                    v => Star.Parse(v)));

            builder.HasData(
                new Rating
                {
                    Id = new Guid("76a4eaa4-25a8-4469-93ea-08ccd05a60ae"),
                    Star = new Star(10),
                },
                new Rating
                {
                    Id = new Guid("c34e4947-510b-4083-ae7a-8040c623bc2e"),
                    Star = new Star(10),
                },
                new Rating
                {
                    Id = new Guid("6ac06f71-b7fb-4c1f-b6d6-014faf2be2b6"),
                    Star = new Star(9),
                },
                new Rating
                {
                    Id = new Guid("fa7af4e4-aa07-47d0-9bdd-241d899f0d43"),
                    Star = new Star(10),
                },
                new Rating
                {
                    Id = new Guid("9017f600-9bf3-48df-851c-a988fbf538ca"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("7009d22f-43bc-4b75-8063-99c6ef7f73c7"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("d635273d-e4ae-4c80-bf3f-423daf6ef44c"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("d9acba2e-cfd8-47ef-82b6-35f29bcf0f72"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("bdd9f99a-0ce7-48f2-ad91-dd7b2bf54a0a"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("aa87369c-2cde-44e3-a6b2-0ee7863005c4"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("60d0ff04-a35e-4580-a1f8-981ef6b72675"),
                    Star = new Star(5)
                },
                new Rating
                {
                    Id = new Guid("33c0c66c-65db-4c6d-b65b-8453ca9c36a4"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("92fde2b4-2f7e-4713-873e-3e19b3d00380"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("dd4e4db2-4cfe-4174-b668-9255234867cb"),
                    Star = new Star(9)
                },
                new Rating
                {
                    Id = new Guid("ec0157b5-7919-4093-a2ff-5edfd5b2e579"),
                    Star = new Star(9)
                },
                new Rating
                {
                    Id = new Guid("109ae507-d931-4fa5-b842-83bbf14af8e3"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("510b4e8e-33eb-4103-a29a-d7cfe3bd1b84"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("41914417-576b-4177-8c91-a706b2402aa4"),
                    Star = new Star(3)
                },
                new Rating
                {
                    Id = new Guid("a5f4fef1-f6ff-4d19-8298-2987bb522d50"),
                    Star = new Star(4)
                },
                new Rating
                {
                    Id = new Guid("50fad2c1-ec6f-4a22-9cf7-ac22ed7b7ba8"),
                    Star = new Star(2)
                },
                new Rating
                {
                    Id = new Guid("b4319a50-d682-4944-af47-369c79a879bd"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("7d7cf2c1-6d67-4b3b-9db6-10ee12e2f85b"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("92353641-44ee-4bd6-a75f-c3dc0d8ed456"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("6e0fed50-8009-40cd-bbef-fa668abffd9e"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("5beaf703-85ff-4272-aeb9-6ec279cf5417"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("29b91bf0-cee2-46ad-9f05-ff01382faf84"),
                    Star = new Star(4)
                },
                new Rating
                {
                    Id = new Guid("b110b30c-67dc-43c4-81bf-1208a921f27f"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("d452ee9c-7f5e-46ac-9ff7-243997b3e463"),
                    Star = new Star(5)
                },
                new Rating
                {
                    Id = new Guid("cb7ae9bc-1abc-4712-9a8b-dc7ad52f311d"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("3d455335-0b64-4220-8efb-5508fe1336fc"),
                    Star = new Star(2)
                },
                new Rating
                {
                    Id = new Guid("0cd3fefc-968d-4387-a657-5308ea1e78e4"),
                    Star = new Star(1)
                },
                new Rating
                {
                    Id = new Guid("1109cbd5-93ef-4145-a29a-32ae758bf92c"),
                    Star = new Star(3)
                },
                new Rating
                {
                    Id = new Guid("00363923-b800-4958-8e73-a3ae096453d9"),
                    Star = new Star(3)
                },
                new Rating
                {
                    Id = new Guid("9baacbc3-8000-46e5-b57f-f664bb35e456"),
                    Star = new Star(3)
                },
                new Rating
                {
                    Id = new Guid("b6410b02-82b2-4244-8445-442de29908d3"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("5f7ef726-22d2-4f7e-80f4-1ab24c3c26a9"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("7235e79b-3794-4d03-a78c-cf724772778b"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("704cd083-5dea-4599-a95a-618687fcd5fe"),
                    Star = new Star(1)
                },
                new Rating
                {
                    Id = new Guid("62480509-2c97-473f-bbe9-c097a4c46f5f"),
                    Star = new Star(2)
                },
                new Rating
                {
                    Id = new Guid("6ca7dcad-8db9-4956-ba9b-7c53f00cd69a"),
                    Star = new Star(3)
                },
                new Rating
                {
                    Id = new Guid("53ee0e5a-70be-4c6f-8e65-b908ed399ee5"),
                    Star = new Star(5)
                },
                new Rating
                {
                    Id = new Guid("19d162da-67fa-4712-8d4f-3bffc4d83d47"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("510e4555-d700-4284-8a12-27569c80a98f"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("853a954d-652b-4e12-9aff-88585f53fa32"),
                    Star = new Star(10)
                },
                new Rating
                {
                    Id = new Guid("8caf4fc5-f4af-4fa9-a00b-d6ae1b98833a"),
                    Star = new Star(9)
                },
                new Rating
                {
                    Id = new Guid("bdfa3907-806f-4932-b974-63c9f56f76cf"),
                    Star = new Star(9)
                },
                new Rating
                {
                    Id = new Guid("d6892c99-c8eb-4fc9-845f-98340576d868"),
                    Star = new Star(9)
                },
                new Rating
                {
                    Id = new Guid("03bed403-761f-4c26-85b7-0f45b9cfdd18"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("52f05984-2671-4482-ab52-63585f5cc9dd"),
                    Star = new Star(8)
                },
                new Rating
                {
                    Id = new Guid("d4f5c5cd-c093-44f5-8cb3-cad53c281aac"),
                    Star = new Star(7)
                },
                new Rating
                {
                    Id = new Guid("522eb814-935f-4ba6-90ef-2309e3e6b1c6"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("2dc113d1-c9bc-48f9-b18e-b62381ff853a"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("46632975-c0d8-471b-ada2-7a5fe6c3b4af"),
                    Star = new Star(6)
                },
                new Rating
                {
                    Id = new Guid("0b72821c-2c78-46de-8eae-7c2bf1573e4c"),
                    Star = new Star(5)
                },
                new Rating
                {
                    Id = new Guid("9f296723-66a5-403c-9d98-e21650f88ce4"),
                    Star = new Star(4)
                },
                new Rating
                {
                    Id = new Guid("abe5c938-b5cd-4dbd-9602-b7ce2c31d232"),
                    Star = new Star(4)
                }
            );
        }
    }
}