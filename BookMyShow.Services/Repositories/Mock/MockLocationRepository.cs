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
            return _context.SingleOrDefault<Location>(id);
        }

        public IEnumerable<Location> GetAll(Expression<Func<IEntity, bool>> filter = null)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Locations")
                        .Where(filter.ToString());

            return _context.Query<Location>(query);
        }

        public IEnumerable<Location> GetAll()
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Location");

            return _context.Query<Location>(query);
        }
    }
}
