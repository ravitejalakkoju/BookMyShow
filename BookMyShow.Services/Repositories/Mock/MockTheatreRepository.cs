using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockTheatreRepository : ITheatreRepository
    {
        private readonly DBContext _context;

        public MockTheatreRepository(DBContext context)
        {
            _context = context;
        }

        public Theatre Get(int theatreId)
        {
            return _context.SingleOrDefault<Theatre>(theatreId);
        }

        public IEnumerable<TheatreView> GetAllForMovieAtLocation(int locationId, int movieId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("TheatreScreens")
                        .Where("LocationID = @0 and MovieID = @1", locationId, movieId);

            return _context.Query<TheatreView>(query);
        }
    }
}
