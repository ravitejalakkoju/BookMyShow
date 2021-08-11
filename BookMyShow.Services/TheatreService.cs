using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.DBModels;
using BookMyShow.Models.Theatre;
using BookMyShow.Services.Interfaces;
using AutoMapper;

namespace BookMyShow.Services
{
    public class TheatreService: ITheatreService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public TheatreService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public TheatreDTO Get(int theatreId)
        {
            return _mapper.Map<TheatreDTO>(_context.SingleOrDefault<Theatre>(theatreId));
        }
        public IEnumerable<TheatreDTO> GetAllForMovieAtLocation(int locationId, int movieId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("*")
                        .From("TheatreScreens")
                        .Where("LocationID = @0 and MovieID = @1", locationId, movieId);

            return _mapper.Map<IEnumerable<TheatreDTO>>(_context.Query<TheatreView>(query));
        }
    }
}
