using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        public readonly DBContext _context;

        public ITheatreRepository _theatreRepository { get; private set; }

        public LocationRepository(DBContext context, ITheatreRepository theatreRepository)
        {
            _context = context;
            _theatreRepository = theatreRepository;
        }

        public Location Get(long id)
        {
            return _context.Single<Location>(id);
        }

        public IEnumerable<Location> GetAll()
        {
            return _context.Query<Location>("select * from " + nameof(Location));
        }

    }
}
