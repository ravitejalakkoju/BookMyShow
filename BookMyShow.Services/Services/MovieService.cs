using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Models.DTO;

namespace BookMyShow.Services
{
    public class MovieService
    {
        private readonly IMovieWrapper _movieWrapper;

        private readonly IMapper _mapper;

        public MovieService(IMovieWrapper movieWrapper, IMapper mapper)
        {
            _movieWrapper = movieWrapper;
            _mapper = mapper;
        }

        public MovieDTO GetMovieDetails(int movieId)
        {
            var movieDetails = _movieWrapper.MovieRepository.GetDetails(movieId);

            return _mapper.Map<MovieDTO>(movieDetails);
        }

        public IEnumerable<MovieDTO> GetMoviesByLocation(int locationId)
        {
            return _mapper.Map<IEnumerable<MovieDTO>>(_movieWrapper.MovieRepository.GetAllAtLocation(locationId));
        }

        public IEnumerable<LanguageDTO> GetLanguages()
        {
            return _mapper.Map<IEnumerable<LanguageDTO>>(_movieWrapper.LanguageRepository.GetAll());
        }

    }
}
