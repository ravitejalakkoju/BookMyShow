using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services
{
    public class SeatService
    {
        public ITheatreWrapper _theatreWrapper;
        public IMapper _mapper;
        public SeatService(ITheatreWrapper theatreWrapper, IMapper mapper)
        {
            _theatreWrapper = theatreWrapper;
            _mapper = mapper;
        }

        public IEnumerable<SeatDTO> GetSeatsInScreen(int screenId)
        {
            return _mapper.Map<IEnumerable<SeatDTO>>(_theatreWrapper.SeatRepository.GetAllInScreen(screenId));
        }

        public IEnumerable<SeatsInScreenDTO> GetSeatCountPerScreen()
        {
            return _mapper.Map<IEnumerable<SeatsInScreenDTO>>(_theatreWrapper.SeatRepository.GetAvailableSeatsPerScreen());
        }
    }
}
