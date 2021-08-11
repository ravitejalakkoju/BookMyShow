using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.DBModels;
using BookMyShow.Models.Theatre;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class SeatService: ISeatService
    {
        public DBContext _context;
        public IMapper _mapper;

        public SeatService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<SeatDTO> GetAllInScreen(int screenId)
        {
            return _mapper.Map<IEnumerable<SeatDTO>>(_context.Query<Seat>("select * from Seat where ScreenID = @0", screenId));
        }

        public IEnumerable<SeatsInScreenDTO> GetAvailableSeatsPerScreen()
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("SeatsInScreen");

            return _mapper.Map<IEnumerable<SeatsInScreenDTO>>(_context.Query<SeatsInScreen>(query));
        }
    }
}
