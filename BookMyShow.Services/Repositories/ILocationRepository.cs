using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities; 

namespace BookMyShow.Services.Repositories
{
    public interface ILocationRepository: IQueryRepository<Location>
    {
        ITheatreRepository _theatreRepository { get; }

    }
}
