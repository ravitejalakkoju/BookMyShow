using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockLocationRepository : ILocationRepository
    {
        public DBContext _context;

        public MockLocationRepository(DBContext context)
        {
            _context = context;
        }

        public Location Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetAll()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Location");

            return _context.Query<LocationView>(query);
        }

        public LocationView GetView(int id)
        {
            return _context.SingleOrDefault<LocationView>(id);
        }

        public IEnumerable<LocationView> GetAllViews()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Locations");

            return _context.Query<LocationView>(query);
        }

    }
}
