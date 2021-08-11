using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models.Location;
using BookMyShow.DBModels;
using AutoMapper;

namespace BookMyShow.Services
{
    public class LocationService: ILocationService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        
        public LocationService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public LocationDTO Get(int locationId)
        {
            return _mapper.Map<LocationDTO>(_context.SingleOrDefault<LocationView>(locationId));
        }

        public IEnumerable<LocationDTO> GetAll()
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("Locations");

            return _mapper.Map<IEnumerable<LocationDTO>>(_context.Query<LocationView>(query));
        }
    }
}
