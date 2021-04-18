using System;
using AutoMapper;
using SharedKernel.Domain;

namespace MistralTask.ViewModels
{
    public class BaseViewModel<TKey> where TKey : IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

        public static implicit operator string(BaseViewModel<TKey> value)
        {
            return value?.ToString();
        }
    }

    public class BaseViewModelProfile : Profile
    {
        public BaseViewModelProfile()
        {
            CreateMap<BaseEntity<Guid>, BaseViewModel<Guid>>().ReverseMap();
            CreateMap<AggregateRoot<Guid>, BaseViewModel<Guid>>().ReverseMap();
        }
    }
}