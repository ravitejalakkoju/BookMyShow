using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Movie;
using BookMyShow.DBModels;
using AutoMapper;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class MovieProfile: Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieView, MovieDTO>()
                .ForSourceMember(d => d.LocationID, opts => opts.DoNotValidate());
            CreateMap<Language, LanguageDTO>();
            CreateMap<Genre, GenreDTO>();
        }
    }
}
