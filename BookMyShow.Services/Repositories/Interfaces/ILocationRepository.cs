using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        public Location Get(int id);

        public IEnumerable<Location> GetAll();

        public IEnumerable<Location> GetAll(Expression<Func<IEntity, bool>> filter = null);
    }
}
