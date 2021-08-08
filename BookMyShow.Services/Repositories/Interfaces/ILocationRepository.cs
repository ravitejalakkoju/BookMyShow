using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ILocationRepository: IRepository<Location>
    {
        public IEnumerable<Location> GetAll();

        public LocationView GetView(int locationId);

        public IEnumerable<LocationView> GetAllViews();
    }
}
