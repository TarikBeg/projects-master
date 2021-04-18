using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MistralTask.ViewModels;
using SharedKernel.Domain;
using SharedKernel.Models;

namespace SharedKernel.ViewModels
{
    public class MovieViewModel : BaseViewModel<Guid>
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public List<ActorViewModel> Actors { get; set; }

        public class MovieViewModelProfile : Profile
        {
            public MovieViewModelProfile()
            {
                CreateMap<Movie, MovieViewModel>()
                    .IncludeBase<BaseEntity<Guid>, BaseViewModel<Guid>>()
                    .ForMember(dest => dest.Rating,
                        opt => opt.MapFrom(src => src.AverageRating))
                    .ForMember(dest => dest.Actors,
                        opt => opt.MapFrom(src => src.CastMovie.Cast.CastActors.Select(x => x.Actor)));
            }
        }
    }
}