using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Location;

namespace BookMyShow.Services.Interfaces
{
    public interface ILocationService
    {
        public IEnumerable<LocationDTO> GetAll();

        public LocationDTO Get(int locationId);
    }
}
