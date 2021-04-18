using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Domain;

namespace SharedKernel.Data.Configurations
{
    public abstract class AggregateRootTypeConfiguration<TEntity, TKey> : BaseEntityTypeConfiguration<TEntity, TKey>
        where TEntity : AggregateRoot<TKey> where TKey : IEquatable<TKey>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.DomainEvents);
        }
    }

    public abstract class
        AggregateRootTypeConfigurationNoVersioning<TEntity, TKey> : BaseEntityTypeConfigurationNoVersioning<TEntity,
            TKey> where TEntity : AggregateRoot<TKey> where TKey : IEquatable<TKey>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.DomainEvents);
        }
    }
}