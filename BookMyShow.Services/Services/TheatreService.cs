using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;
using AutoMapper;

namespace BookMyShow.Services
{
    public class TheatreService
    {
        private ITheatreWrapper _theatreWrapper;
        private IMapper _mapper;

        public TheatreService(ITheatreWrapper theatreWrapper, IMapper mapper)
        {
            _theatreWrapper = theatreWrapper;
            _mapper = mapper;
        }

        public TheatreDTO GetTheatre(int theatreId)
        {
            return _mapper.Map<TheatreDTO>(_theatreWrapper.TheatreRepository.Get(theatreId));
        }
        public IEnumerable<TheatreDTO> GetTheatresForMovieInLocation(int locationId, int movieId)
        {
            return _mapper.Map<IEnumerable<TheatreDTO>>(_theatreWrapper.TheatreRepository.GetAllForMovieAtLocation(locationId, movieId));
        }
    }
}
