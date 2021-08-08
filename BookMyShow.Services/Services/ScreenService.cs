using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.DTO;
using BookMyShow.Services.Repositories.Interfaces;
using AutoMapper;

namespace BookMyShow.Services
{
    public class ScreenService
    {
        public ITheatreWrapper _theatreWrapper;
        public IMapper _mapper;
        public ScreenService(ITheatreWrapper theatreWrapper, IMapper mapper)
        {
            _theatreWrapper = theatreWrapper;
            _mapper = mapper;
        }

        public ScreenDTO Get(int screenId)
        {
            return _mapper.Map<ScreenDTO>(_theatreWrapper.ScreenRepository.Get(screenId));
        }
    }
}
