using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Models;

namespace SharedKernel.Data.Configurations.CoreDbContext
{
    public class ActorEntityTypeConfiguration : BaseEntityTypeConfigurationNoVersioning<Actor, Guid>
    {
        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

            builder
                .HasMany(p => p.CastActors)
                .WithOne(p => p.Actor);

            builder.HasData(
                new Actor
                {
                    Id = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"),
                    FirstName = "Brad",
                    LastName = "Pit",
                },
                new Actor
                {
                    Id = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"),
                    FirstName = "Peter",
                    LastName = "Dinklage",
                },
                new Actor
                {
                    Id = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"),
                    FirstName = "Lena",
                    LastName = "Headey",
                },
                new Actor
                {
                    Id = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"),
                    FirstName = "Emilia",
                    LastName = "Clarke",
                },
                new Actor
                {
                    Id = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"),
                    FirstName = "Kit",
                    LastName = "Harington",
                },
                new Actor
                {
                    Id = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"),
                    FirstName = "Sophie",
                    LastName = "Turner",
                }
            );
        }
    }
}