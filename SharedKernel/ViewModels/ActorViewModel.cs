using System;
using AutoMapper;
using MistralTask.ViewModels;
using SharedKernel.Domain;
using SharedKernel.Models;

namespace SharedKernel.ViewModels
{
    public class ActorViewModel : BaseViewModel<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public class ActorViewModelProfile : Profile
        {
            public ActorViewModelProfile()
            {
                CreateMap<Actor, ActorViewModel>()
                    .IncludeBase<BaseEntity<Guid>, BaseViewModel<Guid>>();
            }
        }
    }
}