using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Domain;

namespace SharedKernel.Data.Configurations
{
    public abstract class BaseEntityTypeConfiguration<TEntity, TKey> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.CreatedAt)
                .IsRequired();
        }
    }

    public abstract class BaseEntityTypeConfigurationNoVersioning<TEntity, TKey> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Ignore(p => p.RowVersion);

            builder
                .Property(p => p.CreatedAt)
                .IsRequired();
        }
    }
}